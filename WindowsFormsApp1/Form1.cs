using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var characterBuilder = new CharacterBuilder();
            if (radioButton1.Checked) 
            {
                characterBuilder.SetColor("Лучник");
                MessageBox.Show("Вид персонажа лучник");
            }
            if (radioButton2.Checked)
            {
                characterBuilder.SetColor("Мечник");
                MessageBox.Show("Вид персонажа мечник");
            }

            if(radioButton4.Checked)
            {
                characterBuilder.SetSize("12");
                MessageBox.Show("Урон 12");
            }
            if (radioButton5.Checked) 
            {
                characterBuilder.SetSize("10");
                MessageBox.Show("Урон 10");
            }
            
            if (radioButton6.Checked)
            {
                characterBuilder.SetType("Меч");
                MessageBox.Show("Персонаж з мечем ");
            }
            if (radioButton7.Checked)
            {
                characterBuilder.SetType("Лук");
                MessageBox.Show("Персонаж з луком ");
            }
            if (radioButton8.Checked)
            {
                characterBuilder.SetType("Посох");
                MessageBox.Show("Персонаж з посохом ");
            }


            var character = characterBuilder.GetCharacter();
            var characterImage = GetСharacterImage(character);

            var copy = character.DeepCopy();
            var characterImages = CopyCharacter(copy);
        }


        private Image GetСharacterImage(Сharacter character)
        {
            if (character.Color == "Лучник")
            {
                return pictureBox1.Image = Resource1.rrt;
            }
            else
            {
                return pictureBox1.Image = Resource1.rrtt;
            }
        }

        private Image CopyCharacter(Сharacter copy )
        {
            if (copy.Color == "Лучник")
            {
                return pictureBox2.Image = Resource1.rrt;
            }
            else
            {
                return pictureBox2.Image = Resource1.rrtt;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }     
}
