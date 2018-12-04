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
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Net.Sockets;

namespace IPZ_System_bus_tickets_sale
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();

             Connect("10.128.36.86", 4);

        }

        private void button55_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

            Window2 f2 = new Window2();
            f2.Show();
        }

        String prices = String.Empty;
        private void button56_Click(object sender, RoutedEventArgs e)
        {
            bool ticket = false;

            if (!ticket)
            {
                MessageBox.Show("Невибране місце");
            }
            else
                Connect("192.168.137.1", 5);
        }

        public void Connect(String server, int index)
        {
            // index = 1  -   надсилання запиту для перевірки аунтифікації
            // index = 2  -   надсилання запиту для реєстрації користувача
            // index = 3  -   надсилання запиту для пошуку маршруту
            // index = 4  -   надсилання запиту для пошуку місць
            // index = 5  -   надсилання запиту для оформлення замовлення


            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////
            //
            //index = 4  -   надсилання запиту для пошуку місць
            //
            ////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////
            if (index == 4)
            {
                try
                {
                    // створюємо TcpClient.
                    // Для е TcpListener 
                    // настроюємо на IP нашого сервера і той самий порт.
                    String responseData = String.Empty;

                    Int32 port = 9595;
                    TcpClient client = new TcpClient(server, port);

                    // Переводимо наше повідомлення в ЮТФ8, а потім в масив Byte.
                    Byte[] data = System.Text.Encoding.UTF8.GetBytes(index.ToString() + "");

                    // Получаемо потік для читання і запису даних.
                    NetworkStream stream = client.GetStream();

                    //відправяємо повідомлення  серверу. 

                    stream.Write(data, 0, data.Length);

                    // Масив для зберігання отриманих даних.
                    data = new Byte[512];

                    // Читаемо перший пакет відповіді сервера.      
                    String[] place = new String[54];
                    String price = String.Empty;
                    String pls = String.Empty;
                    String wagon_number = String.Empty;
                    stream.Read(data, 0, 512);
                    responseData = System.Text.Encoding.UTF8.GetString(data);

                    if (responseData[0] != '9')
                    {

                    }
                    else
                    {
                        MessageBox.Show("\n\tНеможливо звязатися з сервером,\nспробуйте ще раз ");
                    }

                    stream.Close();
                    client.Close();
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("ArgumentNullException: {0}", e);
                    MessageBox.Show("Немає звязку з сервером");
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                    MessageBox.Show("Немає звязку з сервером");
                }

            }
            else
                if (index == 5)
                {
                    try
                    {
                        // створюємо TcpClient.
                        // Для е TcpListener 
                        // настроюємо на IP нашого сервера і той самий порт.
                        String responseData = String.Empty;

                        Int32 port = 9595;
                        TcpClient client = new TcpClient(server, port);

                        // Переводимо наше повідомлення в ЮТФ8, а потім в масив Byte.
                        Byte[] data = System.Text.Encoding.UTF8.GetBytes(index.ToString() + "");

                        // Получаемо потік для читання и запису даних.
                        NetworkStream stream = client.GetStream();

                        //відправяємо повідомлення  серверу. 

                        stream.Write(data, 0, data.Length);

                        data = new Byte[512];

                        // Масив для зберігання отриманих даних.

                        // Читаемо перший пакет відповіді сервера. 
     
                        String[] place = new String[54];
                        String price = String.Empty;
                        String pls = String.Empty;

                        stream.Read(data, 0, 512);
                        responseData = System.Text.Encoding.UTF8.GetString(data);

                        if (responseData[0] != '9')
                        {
                            MessageBox.Show("Квитки заброньовано :)");

                        }
                        else
                        {
                            MessageBox.Show("Не вдалося забронювати квитки :( ");
                        }

                        stream.Close();
                        client.Close();
                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine("ArgumentNullException: {0}", e);
                        MessageBox.Show("Немає звязку з сервером");
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine("SocketException: {0}", e);
                        MessageBox.Show("Немає звязку з сервером");
                    }

                }

        }

    }
}
