// using System;
// public class ReadDataFile
// {
//     // variables
//     public List<Reference> _reference = new List<Reference>();
//     public List<Scripture> _scripture = new List<Scripture>();
//     private string _fileName = "DataText.txt";
//     private string _ref;
//     private string _script;

//     public void LoadReference()
//     // Method to check if txt file is created and load it into the list.  
//     // This should replace any current info in the list
//     {
//         List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

//         foreach (string line in readText)
//         {
//             string[] entries = line.Split(";");

//             Reference entry = new Reference();

//             entry._book = entries[1];
//             entry._chapter = int.Parse(entries[2]);
//             entry._verseStart = int.Parse(entries[3]);
//             entry._verseEnd = int.Parse(entries[4]);

//             _reference.Add(entry);
//         }
//     }

//     public void LoadScriptures()
//     {
//         List<string> readText = File.ReadAllLines(_fileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();

//         foreach (string line in readText)
//         {
//             string[] entries = line.Split(";");

//             Scripture entry = new Scripture();

//             entry._text = entries[6];

//             _scripture.Add(entry);
//         }
//     }

//     public void ReferenceDisplay()
//     {
//         foreach (Reference item in _reference)
//         {
//             // var test = item._verseEnd.Equals(0);
//             // Console.WriteLine(test);
//             if (item._verseEnd.Equals(0))
//             {
//                 item.ReferenceOne();
//             }
//             else
//             {
//                 item.ReferenceTwo();
//             }
//         }
//     }

//     public void ScriptureDisplay()
//     {
//         foreach (Scripture item in _scripture)
//         {
//             item.ShowScripture();
//         }
//     }


// }

