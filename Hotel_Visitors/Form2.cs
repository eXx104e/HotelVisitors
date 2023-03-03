using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Visitors
{
    public partial class Form2 : Form
    {
        public int rowIndex;

        public Form2(int rowIndexForm1, List<string[]> dataBaseHotel)
        {
            InitializeComponent();

            this.rowIndex = rowIndexForm1 + 1;

            DisplayingInformationCard(dataBaseHotel);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Выводит всю информацию о госте на карточку
        /// </summary>
        /// <param name="dataBaseHotel"></param>
        internal void DisplayingInformationCard(List<string[]> dataBaseHotel)
        {
            // Фамилия,Имя,Отчество,Номер комнаты,Статус,Дата заезда,Дата выезда,Оплата,Путешествую с животными,Дата рождения

            Form1 form1 = new Form1();

            List<string[]> dataBaseHotelList = dataBaseHotel;

            form1.DisplayingTheGuestTable();


            labelFIOFull2.Text = dataBaseHotelList[rowIndex][0].ToString() + " "
                + dataBaseHotelList[rowIndex][1].ToString() + " "
                + dataBaseHotelList[rowIndex][2].ToString();

            labelPayment2.Text = dataBaseHotelList[rowIndex][7].ToString();


            int tempDays = (DateTime.Parse(dataBaseHotelList[rowIndex][6]) - DateTime.Parse(dataBaseHotelList[rowIndex][5])).Days + 1;

            labelNumberDaysVisit2.Text = tempDays.ToString();


            if (dataBaseHotelList[rowIndex][8].ToString() == "да")
            {
                checkBoxAnimal.Checked = true;
            }
            else
            {
                checkBoxAnimal.Checked = false;
            }

            labelDateOfBirth2.Text = dataBaseHotelList[rowIndex][9].ToString();
        }
    }
}
