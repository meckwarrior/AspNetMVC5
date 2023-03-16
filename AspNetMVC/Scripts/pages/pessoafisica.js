$(document).ready(function () {
    $("#CPF").inputmask("999.999.999-99", { removeMaskOnSubmit: true });
    $("#DataNascimento").inputmask("99/99/9999");
    $("#DataNascimento").datepicker(
        {
            defaultDate: new Date() - 30,
            dateFormat: 'dd/mm/yyyy',
            dayNames: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sábado'],
            dayNamesMin: ['D', 'S', 'T', 'Q', 'Q', 'S', 'S', 'D'],
            dayNamesShort: ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb', 'Dom'],
            monthNames: ['Janeiro', 'Fevereiro', 'Março', 'Abril', 'Maio', 'Junho', 'Julho', 'Agosto', 'Setembro', 'Outubro', 'Novembro', 'Dezembro'],
            monthNamesShort: ['Jan', 'Fev', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
            nextText: 'Proximo',
            prevText: 'Anterior'
        });
    //Endereço
    $("#Endereco_Estado").inputmask("AA");
    $("#Endereco_CEP").inputmask("99999-999", { removeMaskOnSubmit: true });
    //Telefones
    $("[id^=Telefones]").inputmask("(99) 9999-9999[9]");
});