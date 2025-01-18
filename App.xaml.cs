namespace Point_Of_Sale
{
    public partial class App : Application
    {
        private readonly DatabaseHelper _databaseService;

        public App(DatabaseHelper databaseService)
        {
            InitializeComponent();

            MainPage = new AppShell();
            _databaseService = databaseService;
        }

        protected override async void OnStart()
        {
            base.OnStart();

            // initialize and Seed Database
            await _databaseService.InitializaDatabaseAsync();
        }
    }
}