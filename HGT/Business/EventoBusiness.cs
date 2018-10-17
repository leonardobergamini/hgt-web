using HGT.Models;
using HGT.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HGT.Business
{
    public class EventoBusiness
    {
        EventoService es;

        public void Adicionar(EventoInsert _evento)
        {

            _evento.DataInicio = ConverterData(_evento.DataInicio);
            _evento.DataFinal = ConverterData(_evento.DataFinal);
            _evento.DataInicioVenda = ConverterData(_evento.DataInicioVenda);
            _evento.DataFinalVenda = ConverterData(_evento.DataFinalVenda);

            _evento.HoraInicioEvento = ConverterHora(_evento.HoraInicioEvento);
            _evento.HoraTerminoEvento = ConverterHora(_evento.HoraTerminoEvento);

            es = new EventoService();
            es.InserirEvento(_evento);

        }

        public Evento BuscarPorNome(string _nome)
        {
            Evento evento = new Evento();
            es = new EventoService();

            evento = es.GetEventoByName(_nome);

            return evento;
        }

        public Evento BuscarPorId(string _id)
        {
            Evento evento = new Evento();
            es = new EventoService();

            evento = es.GetEventoById(_id);

            return evento;
        }

        public void Alterar(EventoInsert _evento)
        {
            Evento evento = new Evento();

            _evento.DataInicio = ConverterData(_evento.DataInicio);
            _evento.DataFinal = ConverterData(_evento.DataFinal);
            _evento.DataInicioVenda = ConverterData(_evento.DataInicioVenda);
            _evento.DataFinalVenda = ConverterData(_evento.DataFinalVenda);

            _evento.HoraInicioEvento = ConverterHora(_evento.HoraInicioEvento);
            _evento.HoraTerminoEvento = ConverterHora(_evento.HoraTerminoEvento);

            es = new EventoService();

            es.UpdateEvento(_evento);

        }

        public void Excluir(string _idEvento)
        {
            es = new EventoService();
            es.DeleteEvento(_idEvento);
        }


        //--------------------------Utilitários-------------------------------

        public string ConverterData(string dataOriginal)
        {
            String dataConvertida;

            var dia = dataOriginal.Substring(0, 2);
            var mes = dataOriginal.Substring(3, 2);
            var ano = dataOriginal.Substring(6, 4);

            dataConvertida = ano + "-" + mes + "-" + dia;

            return dataConvertida;
        }

        public string ConverterHora(string horaOriginal)
        {
            String horaConvertida = "";

            var hora = horaOriginal.Substring(0, 2);
            var minuto = horaOriginal.Substring(3, 2);
            var segundo = "00";

            horaConvertida = hora + ":" + minuto + ":" + segundo;

            return horaConvertida;
        }
    }
}