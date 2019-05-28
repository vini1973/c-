/*
/// <summary>
/// Manipula a exibição (exibir/ocultar) do painel definido, e dos elementos relacionados
/// </summary>
/// <param name="idPanel">ID do "Painel" que será exebido/ocultado pelo componente</param>
/// <param name="idDs">ID da "Descrição Adicional" que será exibido/ocultado pelo componente</param>
/// <param name="idImg">ID da "Imagem" que será gerenciado pelo componente</param>
/// <param name="urlImgAtiva">URL da imagem que será exibida quando painel for ativo</param>
/// <param name="urlImgInativa">URL da imagem que será exibida quando painel for inativo</param>
/// <param name="txtDsAtivo">Texto adicional que será exibida quando painel for ativo</param>
/// <param name="txtDsInativo">Texto adicional que será exibida quando painel for inativo</param>	
*/
function componentePainelOcultavel(idPanel, idDs, idImg, urlImgAtiva, urlImgInativa, txtDsAtivo, txtDsInativo) {	

	objImg			= document.getElementById(idImg);
	objPanel		= document.getElementById(idPanel);
	objDs			= document.getElementById(idDs);
				
	if (objPanel.style.display != "none") {
		objImg.src				= urlImgInativa;
		objPanel.style.display	= "none";
		objDs.innerHTML			= txtDsInativo;
	}
	else {
		objImg.src				= urlImgAtiva;
		objPanel.style.display	= "block";
		objDs.innerHTML			= txtDsAtivo;
	}
}	

