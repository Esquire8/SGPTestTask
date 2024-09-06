using Spire.Doc;

namespace SGPProject
{
    public class WordHelper
    {
        public WordHelper(Document document, string filePath)
        {
            if (File.Exists(filePath))
            {
                document.LoadFromFile(filePath);
            }
            else
            {
                MessageBox.Show("Шаблон отсутсвует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReplaceTemplateItem(Document document, List<string> items)
        {
            Dictionary<string, string> replaceDict = new Dictionary<string, string>()
            {
                { "%Наименование%", $"{items[0]}" },
                { "%Производительность%", $"{items[1]}" },
                { "%Объем работ%", $"{items[2]}" },
                { "%Количество%", $"{items[3]}" },
            };

            foreach (var kvp in replaceDict)
            {
                document.Replace(kvp.Key, kvp.Value, true, true);
            }
        }

        public void SaveFile(Document document, string outputFilePath)
        {
            try
            {
                document.SaveToFile(outputFilePath, FileFormat.Docx);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}