function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('python');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('aventuraCodificacao');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('devweb');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('robotica');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('scratch');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('inventor');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('robosELogo');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('jogos');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}
function atualizarValorDoCurso(nomeDoCurso) {
    var cursoInput = document.getElementById('progDivetidaPython');
    cursoInput.value = nomeDoCurso;
    cursoInput.click(); // Simula o clique no campo escondido para enviar o formulário
}

$(function () {
    // Função para carregar os cursos no select de cursos
    $.ajax({
        url: '/EscolaPequenosGenios/ObterCursos',
        type: 'GET',
        dataType: 'json',
        success: function (cursos) {
            var select = $('select[name="NomeDoCurso"]');
            select.empty();
            select.append($('<option>', { value: '', text: 'Selecione um curso' }));
            $.each(cursos, function (index, curso) {
                select.append($('<option>', { value: curso, text: curso }));
            });
        },
        error: function (xhr, status, error) {
            console.log(error);
        }
    });


    // Função para carregar as séries com base no curso selecionado
    $(document).on('change', 'select[name="NomeDoCurso"]', function () {
        var cursoSelecionado = $(this).val();
        var selectSerie = $('select[name="serie"]');
        selectSerie.empty();

        if (cursoSelecionado === 'ENSINO FUNDAMENTAL 1') {
            // Adicionar opções de 1 a 5 para o Ensino Fundamental I
            for (var i = 1; i <= 5; i++) {
                selectSerie.append($('<option>', { value: i, text: i }));
            }
        } else if (cursoSelecionado === 'ENSINO FUNDAMENTAL 2') {
            // Adicionar opções de 6 a 9 para o Ensino Fundamental II
            for (var j = 6; j <= 9; j++) {
                selectSerie.append($('<option>', { value: j, text: j }));
            }
        } else if (cursoSelecionado === 'ENSINO INFANTIL') {
            // Adicionar opção 1 para o Ensino Infantil
            selectSerie.append($('<option>', { value: 1, text: 1 }));
        } else {
            // Curso não selecionado, exibir opção padrão
            selectSerie.append($('<option>', { value: '', text: 'Selecione uma série' }));
        }
    });

    // Função para buscar o endereço com base no CEP
    $(document).on('change', '#cep', function () {
        var cep = $(this).val();

        // Limpar campos de endereço
        $('#logradouro').val('');
        $('#bairro').val('');
        $('#cidade').val('');
        $('#estado').val('');

        // Verificar se o CEP está no formato válido
        if (/^\d{5}-\d{3}$/.test(cep)) {
            // URL da API do ViaCEP
            var apiUrl = 'https://viacep.com.br/ws/' + cep + '/json/';

            $.ajax({
                url: apiUrl,
                type: 'GET',
                success: function (data) {
                    // Preencher campos de endereço com os dados retornados pela API
                    $('#logradouro').val(data.logradouro);
                    $('#bairro').val(data.bairro);
                    $('#cidade').val(data.localidade);
                    $('#estado').val(data.uf);
                },
                error: function () {
                    // Lide com erros de forma adequada
                }
            });
        }
    });
});

function buscarEndereco() {
    var cep = document.querySelector('input[name="Cep"]').value.replace('-', '');
    var url = 'https://viacep.com.br/ws/' + cep + '/json/';

    fetch(url)
        .then(response => response.json())
        .then(data => preencherEndereco(data))
        .catch(error => console.log(error));
}

function preencherEndereco(data) {
    if (!data.erro) {
        document.querySelector('input[name="Logradouro"]').value = data.logradouro;
        document.querySelector('input[name="Numero"]').value = '';
        document.querySelector('input[name="Cidade"]').value = data.localidade;
        document.querySelector('input[name="Uf"]').value = data.uf;
    } else {
        console.log('CEP não encontrado.');
    }
}

// Adicionar listener ao campo de entrada do CEP
var cepInput = document.querySelector('input[name="Cep"]');
cepInput.addEventListener('blur', buscarEndereco);
cepInput.addEventListener('keydown', function (event) {
    if (event.key === 'Tab') {
        buscarEndereco();
    }
});

function formatarCEP(cep) {
    cep = cep.replace(/\D/g, ''); // Remove caracteres não numéricos do CEP
    cep = cep.replace(/^(\d{5})(\d)/, '$1-$2'); // Insere o traço após os primeiros 5 dígitos
    return cep;
}

//Essa função é para verificar se o valor passado pelo input é String. Se for String não é aceito (é apagado)
function MascaraInteiro(num) {
    var er = /[^0-9/ ().-]/;
    er.lastIndex = 0;
    var campo = num;
    if (er.test(campo.value)) { ///verifica se é string, caso seja então apaga
        var texto = $(campo).val();
        $(campo).val(texto.substring(0, texto.length - 1));
        return false;
    } else {
        return true;
    }
}

//Formata de forma generica os campos (Essa é a função que realmente formata os campos, com a exceção do campo de MOEDA)
function formataCampo(campo, Mascara) {
    var boleanoMascara;

    var exp = /\-|\.|\/|\(|\)| /g
    var campoSoNumeros = campo.value.toString().replace(exp, "");
    var posicaoCampo = 0;
    var NovoValorCampo = "";
    var TamanhoMascara = campoSoNumeros.length;
    for (var i = 0; i <= TamanhoMascara; i++) {
        boleanoMascara = ((Mascara.charAt(i) == "-") || (Mascara.charAt(i) == ".") ||
            (Mascara.charAt(i) == "/"))
        boleanoMascara = boleanoMascara || ((Mascara.charAt(i) == "(") ||
            (Mascara.charAt(i) == ")") || (Mascara.charAt(i) == " "))
        if (boleanoMascara) {
            NovoValorCampo += Mascara.charAt(i);
            TamanhoMascara++;
        } else {
            NovoValorCampo += campoSoNumeros.charAt(posicaoCampo);
            posicaoCampo++;
        }
    }
    campo.value = NovoValorCampo;
    ////LIMITAR TAMANHO DE CARACTERES NO CAMPO DE ACORDO COM A MASCARA//
    if (campo.value.length > Mascara.length) {
        var texto = $(campo).val();
        $(campo).val(texto.substring(0, texto.length - 1));
    }
    //////////////
    return true;
}

function MascaraGenerica(seletor, tipoMascara) {
    setTimeout(function () {
        if (MascaraInteiro(seletor)) {
            if (tipoMascara == 'CPFCNPJ') {
                if (seletor.value.length <= 14) { //cpf
                    formataCampo(seletor, '000.000.000-00');
                } else { //cnpj
                    formataCampo(seletor, '00.000.000/0000-00');
                }
            } else if (tipoMascara == 'DATA') {
                formataCampo(seletor, '00/00/0000');
            } else if (tipoMascara == 'CEP') {
                formataCampo(seletor, '00000-000');
            } else if (tipoMascara == 'TELEFONE') {
                formataCampo(seletor, '(00) 0000-0000');
            } else if (tipoMascara == 'DDD') {
                formataCampo(seletor, '00');
            } else if (tipoMascara == 'CELULAR') {
                formataCampo(seletor, '00000-0000');
            } else if (tipoMascara == 'INTEIRO') {
                formataCampo(seletor, '00000000000');
            } else if (tipoMascara == 'CPF') {
                formataCampo(seletor, '000.000.000-00');
            } else if (tipoMascara == 'CNPJ') {
                formataCampo(seletor, '00.000.000/0000-00');
            } else if (tipoMascara == 'INSCRICAOESTADUAL') {
                formataCampo(seletor, '00.000.00-0');
            }
        }
    }, 200);
}


/*Função para fechar a mensagem (Sucesso ou Erro)*/
$('.close-alert').click(function () {
    $('.alert').hide('hide');
});
