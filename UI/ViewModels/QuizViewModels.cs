using System.Collections.Generic;
using System.Windows.Input;
using UCL.QuizApp.Core;
using WpfApp1.Core.Repositories;
using WpfApp1.UI.ViewModels;



namespace UCL.QuizApp.UI

{

    public class QuizViewModel : ViewModelBase

    {

        private readonly IQuestionRepository _repo;
            
        private List<Question> _questions;

        private int _currentIndex;



        // ── Properties med PropertyChanged ──────────────────────────── 

        private Question _currentQuestion;

        public Question CurrentQuestion

        {

            get => _currentQuestion;

            set { _currentQuestion = value; OnPropertyChanged(); }

        }



        private int _currentScore;

        public int CurrentScore

        {

            get => _currentScore;

            set { _currentScore = value; OnPropertyChanged(); }

        }



        // TODO: tilføj StatusMessage, IsQuizFinished og ProgressValue 



        public ICommand AnswerCommand { get; private set; }



        // ── Constructor ─────────────────────────────────────────────── 

        public QuizViewModel(IQuestionRepository repo)

        {

            _repo = repo;

            // TODO: initialiser AnswerCommand med RelayCommand 

            // TODO: kald LoadQuestions() 

        }



        // ── Metoder ─────────────────────────────────────────────────── 

        private void LoadQuestions()

        {

            // TODO: hent alle spørgsmål fra _repo og sæt CurrentQuestion 

        }



        private void CheckAnswer(object parameter)

        {

            // TODO: konverter parameter til int 

            // TODO: sammenlign med CurrentQuestion.CorrectOptionIndex 

            // TODO: opdater CurrentScore hvis korrekt 

            // TODO: kald NextQuestion() 

        }



        private void NextQuestion()

        {

            // TODO: flyt til næste spørgsmål eller sæt IsQuizFinished = true 

            // TODO: opdater StatusMessage og ProgressValue 

        }

    }

}



