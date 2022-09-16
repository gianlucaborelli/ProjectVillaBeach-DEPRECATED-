using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Documents
{
    //Os novos modelos de Certidões de Registro Civil foram instituidos pelo Decreto Nº 6.828,
    //de 27 de Abril de 2009, tornando obrigatória desde 1º de janeiro de 2010.
    //Certidões emitidas anteriormente permanecerão válidas.
    //Os novos modelos de certidão possuem um número de identificação denominado
    //matrícula, composto por 32 dígitos, em formato padronizado nacionalmente.
    //A matrícula unifica os dados:  número da folha, número do termo, tipo de certidão e número do livro,
    //existentes no modelo antigo, e acrescenta outros números, como o que identifica o cartório, o acervo,
    //o Serviço de Registro Civil e o ano.
    //
    //Composição dos números dos da Matricula
    //
    //  Cartório   Acervo         ANO        N. do livro          N. do Termo
    //9 9 9 9 9 9 . 9 9 . 9 9 . 9 9 9 9 . 9 . 9 9 9 9 9 . 9 9 9 . 9 9 9 9 9 9 9 . 9 9 
    //                   N.do            Tipo             N. da                  Digito
    //                  Serviço       de Certidão         Folha                Verificador

    public class CivilRegistrationNew : Document
    {
        public string Registration { get; set; }

        public DateTime IssueDate
        {
            get
            {
                return _issueDate;
            }
            set
            {
                SetProperty(ref _issueDate, value);
            }
        }
        private DateTime _issueDate;

    }
}
