$(document).ready(function () {
    $('#exportButton').click(function () {
        var doc = new jsPDF();

        // Obtém o conteúdo HTML da tabela
        var tableContent = $('.table')[0].outerHTML;

        // Gera o PDF a partir do conteúdo HTML
        doc.fromHTML(tableContent, 15, 15, {
            width: 180
        });

        // Salva o PDF no dispositivo do usuário
        doc.save('historico.pdf');
    });
});