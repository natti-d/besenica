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

        //pishi izpylneno zapazvane, napravi proverka, centrirai forma
        //изскача нова игра, поправи
        private void nwBtn_Click(object sender, EventArgs e)
        {
            try
            {
                bool exists = false;
                foreach (Words w in allData.allWords)
                {
                    if(w.Word == (newWordIn.Text).ToLower())
                    {
                        exists = true;
                        MessageBox.Show("Думата вече съществува!");
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
                    MessageBox.Show("Успехно добавихте дума!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                string s = (ncCatIn.Text).ToLower();
                s = char.ToUpper(s[0]) + s.Substring(1);

                if (allData.categories.Contains(s))
                {
                    MessageBox.Show("Категорията вече съществува.");
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
                    MessageBox.Show("Успехно добавихте категория!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                MessageBox.Show("Не можете да изтриете думата, защото категорията остава празна.", "Грешка");
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
                    MessageBox.Show("Не можете да изтриете категорията, защото играта остава празна.", "Грешка");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
