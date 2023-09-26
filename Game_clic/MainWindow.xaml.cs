using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Game_clic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Classes.PersonInfo Player = new Classes.PersonInfo("Danil", 100, 10, 1, 0, 0, 5);
        public List<Classes.PersonInfo> Enemys = new List<Classes.PersonInfo>();
        DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public Classes.PersonInfo Enemy;
        public MainWindow()
        {
            InitializeComponent();
            UserInfoPlayer();
            Enemys.Add(new Classes.PersonInfo("Гений на Shadow Fiend Иван", 100, 15, 1, 15, 5, 20));
            Enemys.Add(new Classes.PersonInfo("Снайпер", 20, 5, 1, 5, 2, 15));
            Enemys.Add(new Classes.PersonInfo("Пудж", 200, 18, 3, 10, 8, 40));
        }
        public void UserInfoPlayer()
        {
            if (Player.Glasses > 100 * Player.Level)
            {
                Player.Level++;
                Player.Glasses = 0;
                Player.Health += 100;
                Player.Damage++;
                Player.Armor++;
            }
            playerHealth.Content = "Жизненые показатели: " + Player.Health;
            playerArmor.Content = "Броня: " + Player.Armor;
            playerLevel.Content = "Уровень: " + Player.Level;
            playerGlasses.Content = "Опыт: " + Player.Glasses;
            playerMoney.Content = "Монеты: " + Player.Money;

            dispatcherTimer.Tick += AttackPlayer;
            dispatcherTimer.Interval = new System.TimeSpan(0, 0, 10);
            dispatcherTimer.Start();
            SelectEnemy();
        }
        private void AttackPlayer(object sender, System.EventArgs e)
        {
            
        }
        public void SelectEnemy()
        {
            int Id = new Random().Next(0, Enemys.Count);
            Enemy = new Classes.PersonInfo(
                Enemys[Id].Name,
                Enemys[Id].Health,
                Enemys[Id].Armor,
                Enemys[Id].Level,
                Enemys[Id].Glasses,
                Enemys[Id].Money,
                Enemys[Id].Damage);
        }


    }
}
