﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Operações_Turmas
    {
        Turma t;
        List<Turma> listaTurmas = new List<Turma>();
        public Operações_Turmas()
        {
        }
        public void addAluno(int matricula)
        {
            //Turma turma = new Turma();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Código: ");
            string codigo = Console.ReadLine();

            var alunos = Operações_Aluno._listaAluno;
            
            Turma t = new Turma(nome, codigo, List<);
            listaTurmas.Add(t);
        }
        public void editAluno(int index)
        {
            Console.WriteLine("Aluno: " + listaTurmas[index]._nome);
            Console.WriteLine("CPF: " + listaTurmas[index]._codigo);
            Console.Write("\nO que voce quer alterar?\n[1] para Nome\n[2] para CPF\n[3] para Data de Nascimento\n[4] para Endereço\n[5] para Nota\n\n[9] para retornar\n\n[0] para Sair");
            int opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    listaTurmas[index]._nome = Console.ReadLine();
                    break;
                case 2:
                    listaTurmas[index]._codigo = Console.ReadLine();
                    break;
                case 9:
                    Console.Clear();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
            }
        }
        public void listarAlunos()
        {
            foreach (Turma t in listaTurmas)
            {
                Console.WriteLine(t._nome);
            }
        }
        public void excluiAluno(int index)
        {
            Console.WriteLine("Aluno: " + listaTurmas[index]._nome);
            Console.WriteLine("CPF: " + listaTurmas[index]._codigo);

            Console.WriteLine("Tem certeza que deseja excluir?\n[1] para Sim\n[0] para Não");
            int opcao = int.Parse(Console.ReadLine());
            if (opcao == 1)
            {
                listaTurmas.RemoveAt(index);
            }
            Console.WriteLine("Alunos registrados");
            foreach (Turma t in listaTurmas)
            {
                Console.WriteLine(t._nome);
            }
            if (opcao == 0)
            {
                excluiAluno(index);
            }
        }
    }
}
