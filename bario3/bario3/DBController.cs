using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bario3
{
    class DBController
    {
        public Dictionary<int, Bottle> classificationDB; //Номенклатурный справочник

        private string pathClassifDB = @"D:\projects\Bario3new\bario3\bario3\bin\Debug\classDB.txt"; //Путь к бд справочника номенклатуры
        

        public void Connect()
        {
            classificationDB = new Dictionary<int, Bottle>();
            //Console.WriteLine(classificationDB.Count);
        }

        public void AddPosition(string name, int serial, string type, int weightFull, int weightEmpty, int weightNow, int capacityFull, int capacityNow, int price, int portion)
        {
            //Добавление новой позиции в номенклатурный справочник
            Bottle bottle = new Bottle();

            bottle.name = name;
            bottle.serial = serial;
            bottle.type = type;
            bottle.weightFull = weightFull;
            bottle.weightEmpty = weightEmpty;
            bottle.weightNow = weightNow;
            bottle.capacityFull = capacityFull;
            bottle.capacityNow = capacityNow;
            bottle.price = price;
            bottle.portion = portion;

            classificationDB.Add(classificationDB.Count, bottle);
        }

        public void SaveAll()
        {
            //Сохранить все БД

            string jsonClassDB = JsonConvert.SerializeObject(classificationDB);

            using (StreamWriter sw = new StreamWriter(pathClassifDB))
            {
                sw.Write(jsonClassDB);
            }
        }

        public void LoadAll()
        {
            //Загрузить Все БД

            string jsonClassDB = File.ReadAllText(pathClassifDB);
            if (String.IsNullOrEmpty(jsonClassDB)) return;
            classificationDB = JsonConvert.DeserializeObject<Dictionary<int, Bottle>>(jsonClassDB);
        }

        public void ShowClassDB(DataGridView dg, Dictionary<int, Bottle> dict)
        {
            try
            {
                //Вывести содержимое БД номенклатуры в датагрид
                dg.Columns.Clear();
                dg.Rows.Clear();

                dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dg.Columns.Add("posNum", "Номер");
                dg.Columns.Add("name", "Название");
                dg.Columns.Add("serial", "Серийник");
                dg.Columns.Add("type", "Тип");
                dg.Columns.Add("weightFull", "Вес полной бутылки, гр");
                dg.Columns.Add("weightEmpty", "Вес пустой бутылки, гр");
                dg.Columns.Add("weightNow", "Текущий вес бутылки, гр");
                dg.Columns.Add("capacityFull", "Полный обьем, мл");
                dg.Columns.Add("capacityNow", "Текущий обьем, мл");
                dg.Columns.Add("price", "Цена за порцию, руб");
                dg.Columns.Add("portion", "Порция, мл");

                Console.Write(dict.Count);

                if (dict.Count == 0) return;

                dg.Rows.Add(dict.Count);
                

                foreach (int k in dict.Keys)
                {
                    dg.Rows[k].Cells["posNum"].Value = dict[k].posNum;
                    dg.Rows[k].Cells["name"].Value = dict[k].name;
                    dg.Rows[k].Cells["serial"].Value = dict[k].serial;
                    dg.Rows[k].Cells["type"].Value = dict[k].type;
                    dg.Rows[k].Cells["weightFull"].Value = dict[k].weightFull;
                    dg.Rows[k].Cells["weightEmpty"].Value = dict[k].weightEmpty;
                    dg.Rows[k].Cells["weightNow"].Value = dict[k].weightNow;
                    dg.Rows[k].Cells["capacityFull"].Value = dict[k].capacityFull;
                    dg.Rows[k].Cells["capacityNow"].Value = dict[k].capacityNow;
                    dg.Rows[k].Cells["price"].Value = dict[k].price;
                    dg.Rows[k].Cells["portion"].Value = dict[k].portion;
                }
            }catch(Exception ex)
            { Console.WriteLine(ex.Message); }

        }
    }
}
