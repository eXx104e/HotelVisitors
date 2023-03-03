using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel_Visitors
{
    public partial class Form1 : Form
    {
        int rowIndex;

        string partFullName;

        List<string> statusesGuest = new List<string>();

        public Form1()
        {
            InitializeComponent();

            DisplayingTheGuestTable();
        }

        private void timerForLabel_Tick(object sender, EventArgs e)
        {
            labelTimeNow.Text = DateTime.Now.ToLongTimeString() + " мск";
        }

        private void dataGridViewGuest_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Фамилия, Имя, Отчество, Номер комнаты, Статус, Дата заезда, Дата выезда,
            // Оплата,Путешествую с животными,Дата рождения,Пол

            this.rowIndex = dataGridViewGuest.CurrentCell.RowIndex;

            labelNumberGuest.Text = "Номер гостя - " + dataGridViewGuest[3, rowIndex].Value.ToString();

            labelGuestFIO.Text = dataGridViewGuest[0, rowIndex].Value.ToString() + " "
                + dataGridViewGuest[1, rowIndex].Value.ToString() + " "
                + dataGridViewGuest[2, rowIndex].Value.ToString();

            labelStatusGuestView.Text = dataGridViewGuest[4, rowIndex].Value.ToString();

            labelDateArrival2.Text = dataGridViewGuest[5, rowIndex].Value.ToString();

            labelDateOfDeparture2.Text = dataGridViewGuest[6, rowIndex].Value.ToString();

            List<string[]> tempListGuest = GetHotelDataBase(partFullName, statusesGuest);

            if (tempListGuest[rowIndex][10] == "мужчина")
            {
                pictureBoxGuest.Image = Image.FromFile("man.png");
            }
            else
            {
                pictureBoxGuest.Image = Image.FromFile("woman.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerForLabel.Start();
        }

        private void buttonInfoGuest_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(rowIndex, GetHotelDataBase(partFullName, statusesGuest));
            form2.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.partFullName = textBoxSearchGuest.Text.ToLower();

            List<string> tempStatusesGuest = new List<string>();

            foreach (string status in checkedListBoxStatus.CheckedItems)
            {
                tempStatusesGuest.Add(status);
            }
            this.statusesGuest = tempStatusesGuest;

            if (statusesGuest.Count != 0 || partFullName != null)
            {
                DisplayingTheGuestTable(partFullName, statusesGuest);
            }
        }


        private void buttonSearchStatuses_Click(object sender, EventArgs e)
        {
            this.partFullName = textBoxSearchGuest.Text.ToLower();

            List<string> tempStatusesGuest = new List<string>();

            foreach (string status in checkedListBoxStatus.CheckedItems)
            {
                tempStatusesGuest.Add(status);
            }
            this.statusesGuest = tempStatusesGuest;

            if (statusesGuest.Count != 0 || partFullName != null)
            {
                DisplayingTheGuestTable(partFullName, statusesGuest);
            }
        }





        /// <summary>
        /// Выдает список массивов всех строк базы данных отеля
        /// </summary>
        /// <returns></returns>
        public List<string[]> GetHotelDataBase()
        {
            // Фамилия, Имя, Отчество, Номер комнаты, Статус, Дата заезда, Дата выезда,
            // Оплата,Путешествую с животными,Дата рождения,Пол

            StreamReader dataBaseHotel = new StreamReader("HotelDataBase.txt");
            
            DateTime dateNow = DateTime.Now;



            List<string[]> dataBaseHotelList = new List<string[]>();

            dataBaseHotelList.Add(dataBaseHotel.ReadLine().Split(','));



            string row = dataBaseHotel.ReadLine();

            while (row != null)
            {
                string[] value_row = row.Split(',');

                if (DateTime.Parse(value_row[6]) < dateNow)
                {
                    value_row[4] = "Свободен";
                }
                else if (DateTime.Parse(value_row[5]) <= dateNow && DateTime.Parse(value_row[6]) > dateNow)
                {
                    value_row[4] = "Занят";
                }
                else if (DateTime.Parse(value_row[6]) == dateNow)
                {
                    value_row[4] = "Выписывается";
                }
                else if (DateTime.Parse(value_row[5]) > dateNow)
                {
                    value_row[4] = "Зарезервировал";
                }

                dataBaseHotelList.Add(value_row);

                row = dataBaseHotel.ReadLine();
            }

            dataBaseHotel.Close();

            return dataBaseHotelList;
        }


        /// <summary>
        /// Выдает список массивов определенных строк базы данных отеля
        /// </summary>
        /// <param name="partFullName"></param>
        /// <param name="statuses"></param>
        /// <returns></returns>
        public List<string[]> GetHotelDataBase(string partFullName, List<string> statuses)
        {
            List<string[]> allDataBaseHotelList = GetHotelDataBase();

            List<string[]> partDataBaseHotelList = new List<string[]>();

            string[] headerColumns = allDataBaseHotelList[0];

            partDataBaseHotelList.Add(headerColumns);

            for (int i = 1; i < allDataBaseHotelList.Count; i++)
            {
                // Фамилия,Имя,Отчество,Номер комнаты,Статус,Дата заселения,Дата выселения,
                // Оплата,Путешествую с животными,Дата рождения,Пол

                string fullFIO = allDataBaseHotelList[i][0].ToLower() + " " + allDataBaseHotelList[i][1].ToLower() + " "
                    + allDataBaseHotelList[i][2].ToLower();

                if (statuses.Count == 0 && partFullName == null)
                {
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Count == 0 && fullFIO.Contains(partFullName))
                {
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Contains(allDataBaseHotelList[i][4]) && fullFIO.Contains(partFullName))
                {
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Contains(allDataBaseHotelList[i][4]) && partFullName == null)
                {
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
            }

            return partDataBaseHotelList;
        }


        /// <summary>
        /// Выводит таблицу со всеми гостями отеля и возвращает их список
        /// </summary>
        /// <returns></returns>
        internal List<string[]> DisplayingTheGuestTable()
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add("dataBase");

            List<string[]> allDataBaseHotelList = GetHotelDataBase();

            string[] headerColumns = allDataBaseHotelList[0];

            for (int i = 0; i < 7; i++)
            {
                dataSet.Tables[0].Columns.Add(headerColumns[i]);
            }


            for (int i = 1; i < allDataBaseHotelList.Count; i++)
            {
                string[] tempMassGuestInfo = new string[] { allDataBaseHotelList[i][0], allDataBaseHotelList[i][1]
                    , allDataBaseHotelList[i][2], allDataBaseHotelList[i][3], allDataBaseHotelList[i][4]
                    , allDataBaseHotelList[i][5], allDataBaseHotelList[i][6] };

                dataSet.Tables[0].Rows.Add(tempMassGuestInfo);
            }

            dataGridViewGuest.DataSource = dataSet.Tables[0];

            return allDataBaseHotelList;
        }

        /// <summary>
        /// Выводит таблицу с искомыми гостями отеля по части ФИО и статусу, при их наличии и возвращает их список
        /// </summary>
        /// <param name="partFullName"></param>
        /// <param name="statuses"></param>
        /// <returns></returns>
        internal List<string[]> DisplayingTheGuestTable(string partFullName, List<string> statuses)
        {
            DataSet dataSet = new DataSet();
            dataSet.Tables.Add("dataBase");

            List<string[]> allDataBaseHotelList = GetHotelDataBase();

            List<string[]> partDataBaseHotelList = new List<string[]>();

            string[] headerColumns = allDataBaseHotelList[0];

            partDataBaseHotelList.Add(headerColumns);

            for (int i = 0; i < 7; i++)
            {
                dataSet.Tables[0].Columns.Add(headerColumns[i]);
            }

            for (int i = 1; i < allDataBaseHotelList.Count; i++)
            {
                // Фамилия, Имя, Отчество, Номер комнаты, Статус, Дата заезда, Дата выезда

                string fullFIO = allDataBaseHotelList[i][0].ToLower() + " " + allDataBaseHotelList[i][1].ToLower() + " "
                    + allDataBaseHotelList[i][2].ToLower();

                string[] tempMassGuestInfo = new string[] { allDataBaseHotelList[i][0], allDataBaseHotelList[i][1]
                    , allDataBaseHotelList[i][2], allDataBaseHotelList[i][3], allDataBaseHotelList[i][4]
                    , allDataBaseHotelList[i][5], allDataBaseHotelList[i][6] };


                if (statuses.Count == 0 && partFullName == null)
                {
                    dataSet.Tables[0].Rows.Add(tempMassGuestInfo);
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Count == 0 && fullFIO.Contains(partFullName))
                {
                    dataSet.Tables[0].Rows.Add(tempMassGuestInfo);
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Contains(allDataBaseHotelList[i][4]) && fullFIO.Contains(partFullName))
                {
                    dataSet.Tables[0].Rows.Add(tempMassGuestInfo);
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
                else if (statuses.Contains(allDataBaseHotelList[i][4]) && partFullName == null)
                {
                    dataSet.Tables[0].Rows.Add(tempMassGuestInfo);
                    partDataBaseHotelList.Add(allDataBaseHotelList[i]);
                }
            }

            dataGridViewGuest.DataSource = dataSet.Tables[0];

            return partDataBaseHotelList;
        }

        private void checkedListBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
