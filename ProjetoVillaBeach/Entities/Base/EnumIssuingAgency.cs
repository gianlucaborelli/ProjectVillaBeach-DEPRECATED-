using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Base
{
    /// <summary>
    /// Agencies issuing official documents.
    /// </summary>
    public enum EnumIssuingAgency
    {
        /// <summary>
        /// Secretaria de Segurança Publica.
        /// </summary>
        [Description("Secretaria de Segurança Publica")]
        SSP,
        /// <summary>
        /// Academia Brasileira de Neurocirurgia.
        /// </summary>
        [Description("Academia Brasileira de Neurocirurgia")]
        BNC,
        /// <summary>
        /// Coordenação Geral de Polícia de Imigração da Polícia Federal.
        /// </summary>
        [Description("Coordenação Geral de Polícia de Imigração da Polícia Federal")]
        CGPIPF,
        /// <summary>
        /// Coordenação-Geral de Privilégios e Imunidades.
        /// </summary>
        [Description("Coordenação-Geral de Privilégios e Imunidades")]
        CGPI,
        /// <summary>
        /// Coordenadoria Geral de Polícia Marítima, Aeronáutica e de Fronteiras.
        /// </summary>
        [Description("Coordenadoria Geral de Polícia Marítima, Aeronáutica e de Fronteiras")]
        CGPMAF,
        /// <summary>
        /// Conselho Nacional de Imigração.
        /// </summary>
        [Description("Conselho Nacional de Imigração")]
        CNIG,
        /// <summary>
        /// Confederação Nacional de Transporte.
        /// </summary>
        [Description("Confederação Nacional de Transporte")]
        CNT,
        /// <summary>
        /// Conselho Regional de Enfermagem.
        /// </summary>
        [Description("Conselho Regional de Enfermagem")]
        COREN,
        /// <summary>
        /// Conselho Regional de Economia.
        /// </summary>
        [Description("Conselho Regional de Economia")]
        CORECON,
        /// <summary>
        /// Conselho Regional de Administração.
        /// </summary>
        [Description("Conselho Regional de Administração")]
        CRA,
        /// <summary>
        /// Centro de Referência de Assistência Social.
        /// </summary>
        [Description("Centro de Referência de Assistência Social")]
        CRAS,
        /// <summary>
        /// Conselho Regional de Biblioteconomia.
        /// </summary>
        [Description("Conselho Regional de Biblioteconomia")]
        CRB,
        /// <summary>
        /// Conselho Regional de Contabilidade.
        /// </summary>
        [Description("Conselho Regional de Contabilidade")]
        CRC,
        /// <summary>
        /// Conselho Regional de Estatística.
        /// </summary>
        [Description("Conselho Regional de Estatística")]
        CRE,
        /// <summary>
        /// Conselho Regional de Engenharia e Agronomia.
        /// </summary>
        [Description("Conselho Regional de Engenharia e Agronomia")]
        CREA,
        /// <summary>
        /// Conselho Regional de Corretores de Imóveis.
        /// </summary>
        [Description("Conselho Regional de Corretores de Imóveis")]
        CRECI,
        /// <summary>
        /// Conselho Regional de Fisioterapia e Terapia Ocupacional.
        /// </summary>
        [Description("Conselho Regional de Fisioterapia e Terapia Ocupacional")]
        CREFIT,
        /// <summary>
        /// Conselho Regional de Serviço Social.
        /// </summary>
        [Description("Conselho Regional de Serviço Social")]
        CRESS,
        /// <summary>
        /// Conselho Regional de Farmácia.
        /// </summary>
        [Description("Conselho Regional de Farmácia")]
        CRF,
        /// <summary>
        /// Conselho Regional de Medicina.
        /// </summary>
        [Description("Conselho Regional de Medicina")]
        CRM,
        /// <summary>
        /// Conselho Regional de Nutrição.
        /// </summary>
        [Description("Conselho Regional de Nutrição")]
        CRN,
        /// <summary>
        /// Conselho Regional de Odontologia.
        /// </summary>
        [Description("Conselho Regional de Odontologia")]
        CRO,
        /// <summary>
        /// Conselho Regional de Psicologia.
        /// </summary>
        [Description("Conselho Regional de Psicologia")]
        CRP,
        /// <summary>
        /// Conselho Regional de Profissionais de Relações Públicas.
        /// </summary>
        [Description("Conselho Regional de Profissionais de Relações Públicas")]
        CRPRE,
        /// <summary>
        /// Conselho Regional de Química.
        /// </summary>
        [Description("Conselho Regional de Química")]
        CRQ,
        /// <summary>
        /// Conselho Regional de Representantes Comerciais.
        /// </summary>
        [Description("Conselho Regional de Representantes Comerciais")]
        CRRC,
        /// <summary>
        /// Conselho Regional de Medicina Veterinária.
        /// </summary>
        [Description("Conselho Regional de Medicina Veterinária")]
        CRMV,
        /// <summary>
        /// Carteira Sede Carpina de Pernambuco.
        /// </summary>
        [Description("Carteira Sede Carpina de Pernambuco")]
        CSC,
        /// <summary>
        /// Carteira de Trabalho e Previdência Social.
        /// </summary>
        [Description("Carteira de Trabalho e Previdência Social")]
        CTPS,
        /// <summary>
        /// Diretoria de Identificação Civil.
        /// </summary>
        [Description("Diretoria de Identificação Civil")]
        DIC,
        /// <summary>
        /// Diretoria-Executiva.
        /// </summary>
        [Description("Diretoria-Executiva")]
        DIREX,
        /// <summary>
        /// Divisão de Polícia Marítima, Área e de Fronteiras.
        /// </summary>
        [Description("Divisão de Polícia Marítima, Área e de Fronteiras")]
        DPMAF,
        /// <summary>
        /// Departamento de Polícia Técnica Geral.
        /// </summary>
        [Description("Departamento de Polícia Técnica Geral")]
        DPT,
        /// <summary>
        /// Programa Municipal DST/Aids.
        /// </summary>
        [Description("Programa Municipal DST/Aids")]
        DST,
        /// <summary>
        /// Fundo de Garantia do Tempo de Serviço.
        /// </summary>
        [Description("Fundo de Garantia do Tempo de Serviço")]
        FGTS,
        /// <summary>
        /// Fundação Instituto de Pesquisas Econômicas.
        /// </summary>
        [Description("Fundação Instituto de Pesquisas Econômicas")]
        FIPE,
        /// <summary>
        /// Fundação Lyndolpho Silva.
        /// </summary>
        [Description("Fundação Lyndolpho Silva")]
        FLS,
        /// <summary>
        /// Governo do Estado de Goiás.
        /// </summary>
        [Description("Governo do Estado de Goiás")]
        GOVGO,
        /// <summary>
        /// Carteira de Identidade Classista.
        /// </summary>
        [Description("Carteira de Identidade Classista")]
        CLA,
        /// <summary>
        /// Instituto Félix Pacheco.
        /// </summary>
        [Description("Instituto Félix Pacheco")]
        IFP,
        /// <summary>
        /// Instituto Geral de Perícias.
        /// </summary>
        [Description("Instituto Geral de Perícias")]
        IGP,
        /// <summary>
        /// Instituto de Identificação Civil e Criminal Engrácia da Costa Francisco de Rondônia.
        /// </summary>
        [Description("Instituto de Identificação Civil e Criminal Engrácia da Costa Francisco de Rondônia")]
        IICCECF,
        /// <summary>
        /// Inter-institutional Monitoring Group.
        /// </summary>
        [Description("Inter-institutional Monitoring Group")]
        IIMG,
        /// <summary>
        /// Instituto Médico-Legal.
        /// </summary>
        [Description("Instituto Médico-Legal")]
        IML,
        /// <summary>
        /// Índice de Preços ao Consumidor.
        /// </summary>
        [Description("Índice de Preços ao Consumidor")]
        IPC,
        /// <summary>
        /// Instituto Pereira Faustino.
        /// </summary>
        [Description("Instituto Pereira Faustino")]
        IPF,
        /// <summary>
        /// Ministério da Aeronáutica.
        /// </summary>
        [Description("Ministério da Aeronáutica")]
        MAE,
        /// <summary>
        /// Ministério do Exército.
        /// </summary>
        [Description("Ministério do Exército")]
        MEX,
        /// <summary>
        /// Ministério da Marinha.
        /// </summary>
        [Description("Ministério da Marinha")]
        MMA,
        /// <summary>
        /// Ordem dos Advogados do Brasil.
        /// </summary>
        [Description("Ordem dos Advogados do Brasil")]
        OAB,
        /// <summary>
        /// Ordem dos Músicos do Brasil.
        /// </summary>
        [Description("Ordem dos Músicos do Brasil")]
        OMB,
        /// <summary>
        /// Polícia Civil do Estado de Minas Gerais.
        /// </summary>
        [Description("Polícia Civil do Estado de Minas Gerais")]
        PCMG,
        /// <summary>
        /// Polícia Militar do Estado de Minas Gerais.
        /// </summary>
        [Description("Polícia Militar do Estado de Minas Gerais")]
        PMMG,
        /// <summary>
        /// Polícia Federal.
        /// </summary>
        [Description("Polícia Federal")]
        DPF,
        /// <summary>
        /// Polícia Militar.
        /// </summary>
        [Description("Polícia Militar")]
        POM,
        /// <summary>
        /// Secretaria de Defesa Social (Pernambuco).
        /// </summary>
        [Description("Secretaria de Defesa Social (Pernambuco)")]
        SDS,
        /// <summary>
        /// Secretaria Nacional de Justiça / Departamento de Estrangeiros.
        /// </summary>
        [Description("Secretaria Nacional de Justiça / Departamento de Estrangeiros")]
        SNJ,
        /// <summary>
        /// Secretaria de Estado da Casa Civil.
        /// </summary>
        [Description("Secretaria de Estado da Casa Civil")]
        SECC,
        /// <summary>
        /// Secretaria de Estado de Justiça e Segurança Pública – Mato Grosso.
        /// </summary>
        [Description("Secretaria de Estado de Justiça e Segurança Pública – Mato Grosso")]
        SEJUSP,
        /// <summary>
        /// Carteira de Estrangeiro.
        /// </summary>
        [Description("Carteira de Estrangeiro")]
        SES,
        /// <summary>
        /// Secretaria de Estado da Segurança Pública do Paraná.
        /// </summary>
        [Description("Secretaria de Estado da Segurança Pública do Paraná")]
        SESP,
        /// <summary>
        /// Secretaria da Justiça e Segurança.
        /// </summary>
        [Description("Secretaria da Justiça e Segurança")]
        SJS,
        /// <summary>
        /// Secretaria da Justiça do Trabalho e Cidadania.
        /// </summary>
        [Description("Secretaria da Justiça do Trabalho e Cidadania")]
        SJTC,
        /// <summary>
        /// Secretaria da Justiça do Trabalho e Segurança.
        /// </summary>
        [Description("Secretaria da Justiça do Trabalho e Segurança")]
        SJTS,
        /// <summary>
        /// Secretaria de Polícia Técnico-Científica.
        /// </summary>
        [Description("Secretaria de Polícia Técnico-Científica")]
        SPTC
    }
}
