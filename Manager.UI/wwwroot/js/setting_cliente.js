function fnMoveNavBarMenu(objName) {
	var objs = ['formulario_empresa', 'formulario_endereco', 'formulario_contato', 'formulario_banco', 'formulario_historico', 'formulario_certificado', 'formulario_documento'];
	var obj_LI = document.getElementById("li" + objName);
	var obj_DV = document.getElementById("dv" + objName);

	objs.forEach(function (nome, i) {
		var objli = document.getElementById('li' + nome);
		var objdv = document.getElementById('dv' + nome);
		objli.classList.remove('active');
		objdv.classList.add('visually-hidden');

		obj_LI.classList.add('active');
		obj_DV.classList.remove('visually-hidden');
		console.log('Nome :[' + nome + '] -> ' + objdv.classList);
	});
}

function fnShowEnderecoNovo(obj) {
	var objdv = document.getElementById(obj);

	if (objdv.classList.contains('visually-hidden')) {
		objdv.classList.remove('visually-hidden');
	} else { objdv.classList.add('visually-hidden'); }
}
function fnEnderecoNovo() {
	// Logica para add registro ao grid
	fnShowEnderecoNovo();
}
function fnContatoNovo() {
	// Logica para add registro ao grid
	fnShowEnderecoNovo();
}
function fnInit() {
	fnMoveNavBarMenu('formulario_empresa');
	fnShowEnderecoNovo('dvformulario_endereco_novo');
	fnShowEnderecoNovo('dvformulario_contato_novo');
	fnShowEnderecoNovo('dvformulario_banco_novo');
	fnShowEnderecoNovo('dvformulario_documento_novo');
	fnShowEnderecoNovo('dvformulario_certificado_novo');
}


$(document).ready(function () {
	//alert('CLIENTE Iniciando ...')
	fnInit();
	//alert('CLIENTE Finalizando ...')
});