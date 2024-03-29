﻿using ProjetoVillaBeach.Controles;
using ProjetoVillaBeach.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes.Documents
{
    internal class Cpf
    {
        /// <summary>
        /// Validates if the number entered is a C.P.F.
        /// </summary>        
        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            if (string.IsNullOrEmpty(cpf))
                return false;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "00000000000":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        /// <summary>
        /// Checks if there is any C.P.F. registered in the Database.
        /// </summary>     
        public static bool IsUnique(string cpf)
        {
            using (var ctx = new Contexto())
            {
                var pessoa = ctx.Peoples
                                .Where(p => p.NumeroCpf == ulong.Parse(cpf))
                                .ToList();

                if (pessoa.Count == 0)
                {
                    return true;   
                }
            }

            return false;
        }
    }
}
