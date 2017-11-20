﻿using System.Linq;
using System.Threading.Tasks;
using SimpleToDo.Model.Entities;
using Task = System.Threading.Tasks.Task;

namespace SimpleToDo.Repository.Contracts
{
    public interface IToDoListRepository
    {
        IQueryable<List> GetToDoLists();
        Task<List> GetToDoListById(int id);
        Task CreateToDoList(List list);
        Task UpdateToDoList(List list);
        void RemoveToDoList(List list);
        bool ToDoListExists(int id);
    }
}