using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcelReader : MonoBehaviour
{
    public struct excel_data
    {
        public string speaker;
        public string content;
    }
    public static List<excel_data> read_excel(string file_path)
    {
        List<excel_data>excel_data1 = new List<excvel_data>();
        using (var reader = File.Open(file_path, FileMode.Open,FileAccess.Read))
        {
            using (var reader = ExcelReaderFactory.CreateReader(stream))
            do
            {
                while (reader.Reader())
                {
                    excel_data data = new excel_data();
                    data.speaker = reader
                    data.content = reader
                    excel_data1.Add(data);
                }
            }   while (reader.NextResult());
        }
        return excel_data1;
    }
}
