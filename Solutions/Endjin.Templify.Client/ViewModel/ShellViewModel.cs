namespace Endjin.Templify.Client.ViewModel
{
    #region Using Directives

    using System.ComponentModel.Composition;
    using System.Windows;

    using Caliburn.Micro;

    using Endjin.Templify.Client.Contracts;

    #endregion

    [Export(typeof(IShell))]
    public class ShellViewModel : PropertyChangedBase, IShell
    {
        public string Path
        {
            get;
            set;
        }

        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
                this.NotifyOfPropertyChange(() => this.Name);
                this.NotifyOfPropertyChange(() => this.CanSayHello);
            }
        }

        public bool CanSayHello
        {
            get { return !string.IsNullOrWhiteSpace(this.Name); }
        }

        public void SayHello()
        {
            MessageBox.Show(string.Format("Hello {0}!", this.Name));
        }
    }
}