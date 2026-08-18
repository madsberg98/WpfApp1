using UCL.QuizApp.Core;

namespace WpfApp1.Core.Repositories

{

    public interface IQuestionRepository

    {

        IEnumerable<Question> GetAll();

        Question GetById(int id);

        void Add(Question question);

    }

}