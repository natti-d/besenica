using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace besenica
{
    public partial class addNewThings : Form
    {
        public addNewThings()
        {
            InitializeComponent();
        }
        public bool checkLetters(string word)
        {
            for(int i = 0; i < word.Length; i++)
            {
                MessageBox.Show(word[i].ToString());
                if (!allData.letters.Contains(word[i]))
                {
                    MessageBox.Show("Всички символи трябва да са от българската азбука.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private void nwBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkLetters(newWordIn.Text))
                {
                    bool exists = false;
                    foreach (Words w in allData.allWords)
                    {
                        if (w.Word == (newWordIn.Text).ToLower())
                        {
                            exists = true;
                            MessageBox.Show("Думата вече съществува!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            break;
                        }
                    }
                    if (!exists)
                    {
                        allData.allWords.Add(new Words
                        {
                            Word = (newWordIn.Text).ToLower(),
                            Category = nwCombo.Text
                        });
                        wordDelete.Items.Add((newWordIn.Text).ToLower());
                        MessageBox.Show("Успешно добавихте дума!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                newWordIn.Text = "";
                nwCombo.SelectedIndex = 0;
            }
        }

        private void addNewThings_Load(object sender, EventArgs e)
        {
            allData.updateAllCombo(nwCombo);
            allData.updateAllCombo(dwCat);

            catDelete.Items.Clear();
            foreach(string c in allData.categories)
            {
                catDelete.Items.Add(c);
            }
        }

        private void ncBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkLetters(ncCatIn.Text) && checkLetters(ncWordIn.Text))
                {

                    string s = (ncCatIn.Text).ToLower();
                    s = char.ToUpper(s[0]) + s.Substring(1);

                    if (allData.categories.Contains(s))
                    {
                        MessageBox.Show("Категорията вече съществува.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        allData.categories.Add(ncCatIn.Text);
                        allData.allWords.Add(new Words
                        {
                            Word = (ncWordIn.Text).ToLower(),
                            Category = s
                        });

                        allData.updateAllCombo(nwCombo);
                        allData.updateAllCombo(dwCat);
                        catDelete.Items.Add(s);
                        MessageBox.Show("Успешно добавихте категория!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ncCatIn.Text = "";
                ncWordIn.Text = "";
            }
        }

        private void backToGame_Click(object sender, EventArgs e)
        {
            hangman form = Application.OpenForms["hangman"] as hangman;
            if (form != null)
            {
                allData.updateAllCombo(form.categoryCombo);
            }
            this.Close();
        }

        private void dwCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordDelete.Items.Clear();
            foreach (Words w in allData.allWords)
            {
                if (w.Category == dwCat.Text)
                {
                    wordDelete.Items.Add(w.Word);
                }
            }
        }

        private void wDelete_Click(object sender, EventArgs e)
        {
            string wordDel = wordDelete.SelectedItem as string;
            if (wordDelete.Items.Count > 1)
            {
                allData.allWords.RemoveAll(w => w.Word == wordDel);
                wordDelete.Items.Clear();
                foreach (Words w in allData.allWords)
                {
                    if (w.Category == dwCat.Text)
                    {
                        wordDelete.Items.Add(w.Word);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не можете да изтриете думата, защото категорията остава празна.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteCat_Click(object sender, EventArgs e)
        {
            try
            {
                string categDel = catDelete.SelectedItem as string;
                if (catDelete.Items.Count > 1)
                {
                    allData.allWords.RemoveAll(c => c.Category == categDel);
                    allData.categories.RemoveAll(c => c == categDel);
                    allData.updateAllCombo(dwCat);
                    catDelete.Items.Clear();
                    foreach (string c in allData.categories)
                    {
                        catDelete.Items.Add(c);
                    }
                }
                else
                {
                    MessageBox.Show("Не можете да изтриете категорията, защото играта остава празна.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
