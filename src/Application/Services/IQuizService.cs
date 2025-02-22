using Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IQuizService
    {
        // Таски для асинхронности
        public Task<QuizDto?> GetById(int id);
        public Task<List<QuizDto>> GetAll();
        public Task Add(QuizDto quiz);
        public Task<bool> Update(QuizDto quiz);
        public Task<bool> Delete(int id);
    }
}
