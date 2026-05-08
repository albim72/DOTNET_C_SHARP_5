using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace RunnerWpfExample
{
    public partial class MainWindow : Window
    {
        private List<Runner> runners = new List<Runner>();

        public MainWindow()
        {
            InitializeComponent();

            AddSampleData();
            ShowRunners(runners);
        }

        private void AddSampleData()
        {
            runners.Add(new Runner
            {
                FirstName = "Adam",
                LastName = "Kowalski",
                StartNumber = 125,
                RaceName = "Tatra Sky Marathon",
                TimeInMinutes = 584
            });

            runners.Add(new Runner
            {
                FirstName = "Anna",
                LastName = "Nowak",
                StartNumber = 77,
                RaceName = "Tatra Sky Marathon",
                TimeInMinutes = 560
            });

            runners.Add(new Runner
            {
                FirstName = "Piotr",
                LastName = "Wiśniewski",
                StartNumber = 301,
                RaceName = "Bieg Górski",
                TimeInMinutes = 410
            });
        }

        private void AddRunnerButton_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string raceName = RaceNameTextBox.Text;

            int startNumber;
            int timeInMinutes;

            bool startNumberOk = int.TryParse(StartNumberTextBox.Text, out startNumber);
            bool timeOk = int.TryParse(TimeTextBox.Text, out timeInMinutes);

            if (!startNumberOk || !timeOk)
            {
                MessageBox.Show("Numer startowy i czas muszą być liczbami.");
                return;
            }

            Runner runner = new Runner
            {
                FirstName = firstName,
                LastName = lastName,
                StartNumber = startNumber,
                RaceName = raceName,
                TimeInMinutes = timeInMinutes
            };

            runners.Add(runner);

            ShowRunners(runners);

            ClearTextBoxes();
        }

        private void ShowAllButton_Click(object sender, RoutedEventArgs e)
        {
            ShowRunners(runners);
        }

        private void ShowFastButton_Click(object sender, RoutedEventArgs e)
        {
            var fastRunners =
                from runner in runners
                where runner.TimeInMinutes < 570
                orderby runner.TimeInMinutes
                select runner;

            ShowRunners(fastRunners.ToList());
        }

        private void ShowRunners(List<Runner> runnersToShow)
        {
            RunnersListBox.Items.Clear();

            foreach (Runner runner in runnersToShow)
            {
                RunnersListBox.Items.Add(
                    runner.FirstName + " " +
                    runner.LastName +
                    " | numer: " + runner.StartNumber +
                    " | bieg: " + runner.RaceName +
                    " | czas: " + runner.TimeInMinutes + " min"
                );
            }
        }

        private void ClearTextBoxes()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            StartNumberTextBox.Text = "";
            RaceNameTextBox.Text = "";
            TimeTextBox.Text = "";
        }
    }

    public class Runner
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int StartNumber { get; set; }

        public string RaceName { get; set; }

        public int TimeInMinutes { get; set; }
    }
}
