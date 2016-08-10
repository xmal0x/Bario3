﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario3
{
    public partial class FormMain : Form
    {
        DBController mainDBController;
        public FormMain()
        {
            InitializeComponent();
            mainDBController = new DBController();

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {

            mainDBController.Connect();
            mainDBController.LoadAll();
            mainDBController.ShowClassDB(dataGridViewClassification, mainDBController.classificationDB);
            mainDBController.ShowInventDB(dataGridViewInvent, mainDBController.inventDB);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonAddPosition_Click(object sender, EventArgs e)
        {
            //добавить позицию в номенклатурный справочник
            try
            {
                string name = textBoxAddName.Text;
                int serial = Int32.Parse(textBoxAddSerial.Text);
                string type = textBoxAddType.Text;
                int weightFull = Int32.Parse(textBoxAddWeightFull.Text);
                int weightEmpty = Int32.Parse(textBoxAddWeightEmpty.Text);
                int weightNow = Int32.Parse(textBoxAddWeightNow.Text);
                int capacityFull = Int32.Parse(textBoxAddCapacityFull.Text);
                int capacityNow = Int32.Parse(textBoxAddCapacityNow.Text);
                int price = Int32.Parse(textBoxAddPrice.Text);
                int portion = Int32.Parse(textBoxAddPortion.Text);

                mainDBController.AddPosition(name, serial, type, weightFull, weightEmpty, weightNow, capacityFull, capacityNow, price, portion);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка, одно из значение не верно\n" + ex.Message);
                return;
            }

            mainDBController.ShowClassDB(dataGridViewClassification, mainDBController.classificationDB);


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            mainDBController.SaveAll();
        }

        private void buttonScanPosition_Click(object sender, EventArgs e)
        {
            try
            {
                int weightScan = Int32.Parse(textBoxWeightScan.Text);
                int serialScan = Int32.Parse(textBoxSerialScan.Text);
                mainDBController.ScanPosition(weightScan, serialScan);
                mainDBController.ShowInventDB(dataGridViewInvent, mainDBController.inventDB);
            }catch(Exception ex)
            {
                MessageBox.Show("Ошибка в сканируемых значениях\n" + ex.Message);
            }

        }
    }
}
