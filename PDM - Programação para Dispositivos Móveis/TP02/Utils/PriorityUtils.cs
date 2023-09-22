using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Repositories;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TarefasApp.Utils
{
    class PriorityUtils
    {

        public static TaskPriorityType readFromString(string str)
        {
            switch(str)
            {
                case "Alta":
                    return TaskPriorityType.HIGH;
                case "Média":
                    return TaskPriorityType.MEDIUM;
                default: 
                    return TaskPriorityType.LOW;
            }
        }

        public static String stringFromTaskPriorityType(TaskPriorityType type)
        {
            switch (type)
            {
                case TaskPriorityType.HIGH:
                    return "Alta";
                case TaskPriorityType.MEDIUM:
                    return "Média";
                default:
                    return "Baixa";
            }
        }
    }
}
