using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ToDoList
{
    class MainViewModel
    {
        public ObservableCollection<Purpose> Purposes { get; set; }
        public Command AddPurpose { get; set; }
        public Command DeletePurpose { get; set; }
        public MainViewModel()
        {
            Purposes = new ObservableCollection<Purpose>()
            {   new Purpose ("Купи батон"),
                new Purpose ("Съешь ещё этих мягких французких булок"),
                new Purpose ("Выпей чаю"),
            };

            AddPurpose = new Command(obj => add(obj));
            DeletePurpose = new Command(obj => delete(obj));
        }

        public void add(object obj)
        {
            var title = obj as string;
            Purposes.Add(new Purpose(title));
        }
        public void delete(object obj)
        {
            var purpose = obj as Purpose;
            Purposes.Remove(purpose);
        }

    }
    public class Purpose
    {
        public string Title { get; set; }
        public bool Done { get; set; }
        public Purpose(string Title)
        {
            this.Title = Title;
            this.Done = false;
        }
    }
}
