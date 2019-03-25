using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Net;
using System.Text;

namespace AdvancedFeaturesNetLearn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String fileName = "text.txt";
            
//            IteratorTest();
//            PartialTest();
//            GenericTest();
//            RunFile(fileName);
//            RunStream(fileName);
//            RunWeb(fileName);
            MailTest mailTest = new MailTest();
            mailTest.send();
        }

        private static void GenericTest()
        {
            IGenericInterface<IListSource> factory = new GenericClassTest<DataTable, IListSource>();
            Console.WriteLine(factory.CreateInstance().GetType().ToString());

            int i = Finder.Find(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 6);
            Console.WriteLine("6在数组中的位置：" + i.ToString());
        }

        private static void PartialTest()
        {
            account at = new account();
            Console.WriteLine(at.addition(1, 2));
        }

        private static void IteratorTest()
        {
            IteratorTest iteratorTest = new IteratorTest();

            foreach (var str in iteratorTest)
            {
                Console.WriteLine(str);
            }
        }

        private static void RunFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                FileInfo fileInfo = new FileInfo(fileName);
                Console.WriteLine("名称 {0}", fileInfo.Name);
                Console.WriteLine("路径 {0}", fileInfo.DirectoryName);

                StreamWriter streamWriter = new StreamWriter(fileName, true);
                streamWriter.Write("Test text");
                streamWriter.Close();
            }
            else
            {
                File.Create(fileName);
            }
        }

        private static void RunStream(string fileName)
        {
            StreamReader streamReader = new StreamReader(fileName);
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();

            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            if (binaryReader.PeekChar() != -1)
            {
                Console.WriteLine("文字：" + binaryReader.ReadInt32());
            }

            binaryReader.Close();
            fileStream.Close();

            IPAddress[] ipAddresses = Dns.GetHostAddresses("img.rynxiao.cn");
            foreach (var ip in ipAddresses)
            {
                Console.WriteLine("主机IP地址：{0}", ip.ToString());
            }

            Console.WriteLine("主机名：{0}", Dns.GetHostName());
            Console.WriteLine("DNS 主机名：{0}", Dns.GetHostByName(Dns.GetHostName()).HostName);
        }

        private static void RunWeb(string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.BaseAddress = "http://img.rynxiao.cn";
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            Stream stream = webClient.OpenRead(fileName);
            StreamReader streamReader1 = new StreamReader(stream);
            String str1 = String.Empty;
            while ((str1 = streamReader1.ReadLine()) != null)
            {
                Console.WriteLine(str1);
            }

            webClient.DownloadFile(fileName, DateTime.Now.ToFileTime() + ".txt");
        }
    }
}