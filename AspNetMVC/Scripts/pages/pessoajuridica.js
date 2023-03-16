$(document).ready(function () {
    $("#CNPJ").inputmask(("##.###.###/####-##"), { removeMaskOnSubmit: true });
    //Endereço
    $("#Endereco_Estado").inputmask("AA");
    $("#Endereco_CEP").inputmask("#####-###", { removeMaskOnSubmit: true });
    //Telefones
    $("[id^=Telefones]").inputmask("(##) ####-####[#]");
});