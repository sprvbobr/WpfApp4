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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<ClassBook> books = new List<ClassBook>
        {

       new ClassBook {Name="Заклиначтцица драконов Академия волшебства ",Title="АкадемияВолшебства",strani=90,Money=150,After="Маргаита",genre="Фентези",Howmanychildrentheauthorate= 1000 },
      new ClassBook("А я тебя нет"," нет",90,150,"Хельга","Романтика",10),
      new ClassBook("Родная кровь ","кровь",90,150," Anne","боевик",26),
      new ClassBook(" Гибель Сатурна","сатурн",90,150,"Маргарита","космос",40),
      new ClassBook("Зло действуй ","зло" ,90,150,"Надежда","фентези",43),
      new ClassBook("Ненавистная жена ","жена",90,150,"янина","романтика",54),
      new ClassBook(" Мерседес вина ","машина",90,150,"Марседес ","романтика",46),
      new ClassBook("Край неба  ","небо",90,150," Анна","Роматика",6546),
      new ClassBook("Яма ","болото",90,150,"Борис","ужастик",654),
      new ClassBook(" Совершенные","бог",90,150,"Марина","фентези",654),
      new ClassBook(" Сктрытые намериния ","меры ",90,150,"Майк","ужастик ",87)

};
        
        
        
  public MainWindow()
        {
            InitializeComponent();
            TableBook.ItemsSource = books.
                
                OrderBy(x=>x.Name).
                ThenBy(x=>x.After);
                TableBook.ItemsSource = books.Select(x=>x.Title).Distinct();

        }

        private void FiltredButton(object sender, RoutedEventArgs e)
        {
            TableBook.ItemsSource = books.
                Where(x => x.Title.ToLowerInvariant().
            ToLowerInvariant().Equals(Book.Text.ToLowerInvariant()));

        }
        
    }
}
