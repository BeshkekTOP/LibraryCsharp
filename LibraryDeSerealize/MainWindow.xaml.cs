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
using System;
using System.Windows;
using SerializationLibrary;

namespace WPFApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Person person = new Person { Name = "Максим Лавров", Age = 30 };
            byte[] serializedData = new Serializer().Serialize(person);
            Person deserializedPerson = new Serializer().Deserialize<Person>(serializedData);

            serializationResultTextBlock.Text = $"Сериализация: {serializedData.Length} bytes";
            deserializationResultTextBox.Text = $"Десериализация: {deserializedPerson.Name} {deserializedPerson.Age}";
        }
    }
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
