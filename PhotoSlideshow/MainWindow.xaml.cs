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

            album.SubAlbums.Add(dag1);
            album.SubAlbums.Add(dag2);

            dag1.SubAlbumCollection.AddRange(new List<SubAlbum> { Pantheon, Vatikanet });
            dag2.SubAlbumCollection.AddRange(new List<SubAlbum> { Colosseum, ForumRomanum });

            AddPicturesToSubAlbum(Pantheon, "dag1","pantheon");
            AddPicturesToSubAlbum(Vatikanet, "dag1", "vatikanet");
            AddPicturesToSubAlbum(Colosseum, "dag2", "colosseum");
            AddPicturesToSubAlbum(ForumRomanum, "dag2", "Forum Romanum");

            
        }

        private static void AddPicturesToSubAlbum(SubAlbum Pantheon,string day, string subalbum)
        {
            foreach (string picture in Directory.GetFiles(@"C:\Users\Stefan\Google Drev\Programmering\Projects\PhotoSlideshow\test\" + day + "\\" + subalbum + "\\"))
            {
                Pantheon.Pictures.Add(new Picture(picture));
            }
        }
    }
}
