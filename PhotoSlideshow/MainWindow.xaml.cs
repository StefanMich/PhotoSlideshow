using System;
using System.Collections.Generic;
using System.IO;
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
using PhotoSlideshow.Model;

namespace PhotoSlideshow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Album album = new Album("Rom 2013", "Stefan Micheelsen");
            SubAlbum dag1 = new SubAlbum("Dag 1", "Pantheon og Vatikanet");
            SubAlbum dag2 = new SubAlbum("Dag 2", "Colosseum og Forum Romanum");

            SubAlbum Pantheon = new SubAlbum("Pantheon", "Pantheon");
            SubAlbum Vatikanet = new SubAlbum("Vatikanet", "Vatikanet");
            SubAlbum Colosseum = new SubAlbum("Colosseum", "Colosseum");
            SubAlbum ForumRomanum = new SubAlbum("Forum Romanum", "Forum Romanum");

            album.Items.Add(dag1);
            album.Items.Add(dag2);

            dag1.Items.AddRange(new List<SubAlbum> { Pantheon, Vatikanet });
            dag2.Items.AddRange(new List<SubAlbum> { Colosseum, ForumRomanum });

            AddPicturesToSubAlbum(Pantheon, "dag1","pantheon");
            AddPicturesToSubAlbum(Vatikanet, "dag1", "vatikanet");
            AddPicturesToSubAlbum(Colosseum, "dag2", "colosseum");
            AddPicturesToSubAlbum(ForumRomanum, "dag2", "Forum Romanum");

            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri((((album.Items[0] as SubAlbum).Items[0] as SubAlbum).Items[0] as Picture).Path);
            image.EndInit();

            this.Picture.Source = image;
        }

        private static void AddPicturesToSubAlbum(SubAlbum album,string day, string subalbum)
        {
            foreach (string picture in Directory.GetFiles(@"C:\Users\Stefan\Google Drev\Programmering\Projects\PhotoSlideshow\test\" + day + "\\" + subalbum + "\\"))
            {
                album.Items.Add(new Picture(picture));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
