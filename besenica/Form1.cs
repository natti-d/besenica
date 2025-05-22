using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace besenica
{
    public partial class hangman : Form
    {
        //Всички
        //List<Words> allWords = new List<Words>();
        //List<string> categories = new List<string>();

        //Резултати на потребител
        List<Words> win = new List<Words>();
        List<Words> lose = new List<Words>();

        //За познаване на дума
        string word = null;
        List<char> guess = new List<char>();
        List<char> correctIn = new List<char>();
        List<char> wrongIn = new List<char>();
        int step = 0;

        public hangman()
        {
            InitializeComponent();

            allData.categories.Add("Животни");
            allData.categories.Add("Градове");
            allData.categories.Add("Съществителни");

            //Животни
            allData.allWords.Add( new Words
            {
                Word = "котка",
                Category = allData.categories[0].ToString()
            });

            allData.allWords.Add(new Words
            {
                Word = "жираф",
                Category = allData.categories[0].ToString()
            });

            allData.allWords.Add(new Words
            {
                Word = "пчела",
                Category = allData.categories[0].ToString()
            });

            //Градове
            allData.allWords.Add(new Words
            {
                Word = "софия",
                Category = allData.categories[1].ToString()
            });

            allData.allWords.Add(new Words
            {
                Word = "пловдив",
                Category = allData.categories[1].ToString()
            });

            allData.allWords.Add(new Words
            {
                Word = "бургас",
                Category = allData.categories[1].ToString()
            });

            //Съществителни
            allData.allWords.Add(new Words
            {
                Word = "лаптоп",
                Category = allData.categories[2].ToString()
            });
            allData.allWords.Add(new Words
            {
                Word = "буркан",
                Category = allData.categories[2].ToString()
            });
            allData.allWords.Add(new Words
            {
                Word = "ливада",
                Category = allData.categories[2].ToString()
            });
        }

        private void keyboardMenu_Click(object sender, EventArgs e)
        {
            if(keyboardInput.Visible == false)
            {
                keyboardInput.Visible = true;
                buttonInput.Visible = false;
            }
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (buttonInput.Visible == false)
            {
                keyboardInput.Visible = false;
                buttonInput.Visible = true;
            }
        }

        public void newGameRestart()
        {
            //изчисти снимка и непознати букви
            wrongIn.Clear();
            step1.Text = "";
            step2.Text = "";
            step3.Text = "";
            step4.Text = "";
            step5.Text = "";
            step6.Text = "";
            step7.Text = "";
            step8.Text = "";
            step9.Text = "";
            hanging.Image = Properties.Resources.step0;
            step = 0;
            charInput.ReadOnly = false;
            charInput.Text = null;

            List<string> list = new List<string>();
            int indexCat = categoryCombo.SelectedIndex;
            foreach (Words w in allData.allWords)
            {
                if(w.Category == allData.categories[indexCat].ToString()) 
                {  
                    list.Add(w.Word); 
                }
            }

            Random rand = new Random();
            word = list[rand.Next(list.Count)];

            correctIn.Clear();
            guess.Clear();
            wrongIn.Clear();
            for (int i = 0; i < word.Length; i++)
            {
                guess.Add(word[i]);
                if (word[i] == '-')
                {
                    correctIn.Add('-');
                    continue;
                }
                correctIn.Add('_');
            }

            retypeCorrect();

            MessageBox.Show("Започвате нова игра!", "Нова игра", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void retypeCorrect()
        {
            correctWord.Text = null;
            foreach (char c in correctIn)
            {
                correctWord.Text += c.ToString() + " ";
            }
        }

        private void hangman_Load(object sender, EventArgs e)
        { 
            categoryCombo.Items.Clear();
            foreach(string cat in allData.categories)
            {
                categoryCombo.Items.Add(cat);
            }
            categoryCombo.SelectedIndex = 0;
            //newGameRestart();
        }

        private void restartGame_Click(object sender, EventArgs e)
        {
            newGameRestart();
        }

        private void charBtn_Click(object sender, EventArgs e)
        {
            char ch = ' ';
            try
            {
                ch = char.Parse(charInput.Text);
                checkLetter(ch);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void categoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            newGameRestart();
        }

        private void checkLetter (char ch)
        {
            try
            {
                ch = char.ToLower(ch);
                if (!allData.letters.Contains(ch))
                {
                    MessageBox.Show("Въведете буква от българската азбука.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    charInput.Text = "";
                }
                else
                {
                    if (guess.Contains(ch))
                    {
                        if (correctIn.Contains(ch))
                        {
                            MessageBox.Show("Вече сте въвели тази буква!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            for (int i = 0; i < guess.Count; i++)
                            {
                                if (guess[i] == ch)
                                {

                                    correctIn[i] = ch;
                                }
                            }
                            retypeCorrect();
                            if (!correctIn.Contains('_'))
                            {
                                MessageBox.Show($"Спечелихте играта!\nДумата е {word}.\nПоздравления!", "Победа!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                charInput.ReadOnly = true;
                                win.Add(new Words
                                {
                                    Word = word,
                                    Category = categoryCombo.Text.ToString()
                                });
                                winCount.Text = win.Count.ToString();
                            }
                        }
                    }
                    else
                    {
                        if (wrongIn.Contains(ch))
                        {
                            MessageBox.Show("Вече сте въвели тази буква!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            wrongIn.Add(ch);
                            step++;
                            TextBox txt = this.Controls.Find("step" + step, true).FirstOrDefault() as TextBox;
                            if (txt != null)
                            {
                                txt.Text = ch.ToString();
                            }

                            PictureBox pic = this.Controls.Find("hanging", true).FirstOrDefault() as PictureBox;
                            var image = (Image)Properties.Resources.ResourceManager.GetObject("step" + step);
                            if (image != null)
                            {
                                pic.Image = image;
                            }
                            else
                            {
                                MessageBox.Show("Има проблем с изображението.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                hanging.Image = Properties.Resources.error;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (step == 9)
            {
                MessageBox.Show($"Загубихте играта!\nДумата е {word}.", "Загуба!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                charInput.ReadOnly = true;

                lose.Add(new Words
                {
                    Word = word,
                    Category = categoryCombo.Text.ToString()
                });
            }
        }

        private void clickLetter(object sender, EventArgs e)
        {
            Button clickedLetter = sender as Button;
            checkLetter(char.Parse(clickedLetter.Text));
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            addNewThings form = new addNewThings();
            form.ShowDialog();
        }

        private void downloadResult_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                saveResults.Title = "Open Text file...";
                saveResults.FileName = " ";
                saveResults.Filter = "Text files|*.txt|JPEG|*.jpg|All files|*.*";//"JPEG sdsd |*.jpg,"
                if (saveResults.ShowDialog() == DialogResult.OK)
                {
                    filename = saveResults.FileName;

                    using (StreamWriter write = new StreamWriter(filename))
                    {
                        write.WriteLine("Познати думи: ");
                        for (int i = 0; i < allData.categories.Count; i++)
                        {
                            write.WriteLine($"{allData.categories[i]} (Категория):");
                            foreach (Words w in win)
                            {
                                if (w.Category == allData.categories[i])
                                {
                                    write.WriteLine($"- {w.Word.ToString()};");
                                }
                            }
                        }

                        write.WriteLine("\nСгрешени думи:");
                        for (int i = 0; i < allData.categories.Count; i++)
                        {
                            write.WriteLine($"{allData.categories[i]} (Категория):");
                            foreach (Words w in lose)
                            {
                                if (w.Category == allData.categories[i])
                                {
                                    write.WriteLine($"- {w.Word.ToString()};");
                                }
                            }
                        }

                        write.WriteLine($"\nДата на изтегляне: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}");
                    }
                    MessageBox.Show($"Резултатите са запазени в {filename}.", "Запазване на резултат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            howToPlay howToPlay = new howToPlay();
            howToPlay.Show();
        }
    }
}
