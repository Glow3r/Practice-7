using System.Windows;

namespace Practice_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Sum_Click(object sender, RoutedEventArgs e)
        {
            Vector3D firstVector = new Vector3D(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));
            Vector3D secondVector = new Vector3D(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text), int.Parse(thirdtriadB.Text));
            Vector3D resultVector = firstVector + secondVector;
            MessageBox.Show($"Результат сложения вектора А с вектором В - {resultVector.First} {resultVector.Second} {resultVector.Third}", "Сложение векторов", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ScalarProduct_Click(object sender, RoutedEventArgs e)
        {
            Vector3D firstVector = new Vector3D(int.Parse(firsttriadA.Text), int.Parse(secondtriadA.Text), int.Parse(thirdtriadA.Text));
            Vector3D secondVector = new Vector3D(int.Parse(firsttriadB.Text), int.Parse(secondtriadB.Text), int.Parse(thirdtriadB.Text));
            MessageBox.Show($"Результат скалярного произведения векторов А и В - {Vector3D.ScalarProduction(firstVector, secondVector)}", "Скалярное произведение векторов", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Гаврюшин К. А. ИСП-34.", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

    }
}
