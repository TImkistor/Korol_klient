using MySql.Data.MySqlClient;
using System.Data;

namespace Korol
{

    static class Database
    {
        static MySqlConnection connectionSec = new MySqlConnection("server=127.0.0.1;database=security; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");
        static MySqlConnection connectionFil = new MySqlConnection("server=127.0.0.1;database=turist; Uid=Admin; Pwd=test;SslMode=none;charset=utf8");

        /// <summary>a
        /// Sec table
        /// </summary>
        /// <returns></returns>
        public static DataTable SECURITY()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_SEC`, `FIO` AS `ФИО`, `FIONepolnoe` AS `Сокращено` , `Dolg` AS `Должность` , `Login` AS `Логин`, `Password` AS `Пароль` , `level` AS `Уровень`,`Mesto` AS `Место` FROM `sec`"
          , connectionSec);
            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }


        public static DataTable GROUV()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Group`, grouv.Naim AS `Наименование` FROM grouv", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable MANAAGER()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Manager`, manager.FIO AS `ФИО` FROM manager", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable MAXHIKE()
        {

            MySqlDataAdapter bc = new MySqlDataAdapter
            ("SELECT `ID_Maxhike`, maxhike.Naim AS `Наименование`, tip.Naim AS `Тип`, trainer.FIO AS `Тренер`, maxhike.Route AS `Маршрут`, maxhike.Complexity AS `Сложность` FROM maxhike INNER JOIN tip ON maxhike.ID_Tip = tip.ID_TIP INNER JOIN trainer ON maxhike.ID_Trainer = trainer.ID_Trainer", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable SECTION()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT `ID_Section`, section.Naim AS `Наименование` FROM section", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }

        public static DataTable TIP()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT `ID_TIP`, tip.Naim AS `Наименование` FROM tip", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable TRAINER()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT `ID_Trainer`, trainer.FIO AS `ФИО` FROM trainer", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
        public static DataTable TURIST()
        {
            MySqlDataAdapter bc = new MySqlDataAdapter
                ("SELECT `ID_Turist`, turist.FIO AS `ФИО`, grouv.Naim AS `Группа`, section.Naim AS `Секция`, tip.Naim AS `Тип`, manager.FIO AS `Менеджер`, trainer.FIO AS `Тренер`, maxhike.Naim AS `Маршрут` FROM turist INNER JOIN grouv ON turist.ID_Group = grouv.ID_Group INNER JOIN section ON turist.ID_Section = section.ID_Section INNER JOIN tip ON turist.ID_Tip = tip.ID_TIP INNER JOIN manager ON turist.ID_Manager = manager.ID_Manager INNER JOIN trainer ON turist.ID_Trainer = trainer.ID_Trainer INNER JOIN maxhike ON turist.ID_Maxhike = maxhike.ID_Maxhike", connectionFil);
            MySqlDataAdapter color = new MySqlDataAdapter("SELECT `Color` AS `Цвет` FROM `color`", connectionFil);

            DataTable zx = new DataTable();
            bc.Fill(zx);

            return zx;
        }
    }



    
}
