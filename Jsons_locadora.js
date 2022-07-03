
//Estado
{
	"id": 3,
	"nomeEstado": "Minas Gerais",
	"uf": "MG",
	"pais": "Brasil"
}
//Cidade
{
    "Id":1,
    "NomeCidade":"Belo Horizonte",
    "EstadoId":3,
     "ReadEstadoDTO":{
        "id": 3,
        "nomeEstado": "Minas Gerais",
        "uf": "MG",
        "pais": "Brasil"
    }
}

//Cliente

//CreateClienteDTO

{
	"NomeCliente":"Fulando",
	"SobreNome": "De Tal",
	"CPF":"22222222222",
	"RG":"223334445",
	"TelFixo":"1122334455",
	"Celular":"11923324554",
	"Email":"cliente@teste.com",
	"DtNascimento":"1982-04-05",
	"Ativo":true,
	"CreateEnderecoDTO":{
		"Logradouro":"Rua amarela",
		"Bairro": "Bairro das Cores",
		"CEP":"19023453",
		"FuncionarioId":null,
		"CidadeId":1,
        "Numero":10
	}
}

//UpdateClienteDTO
{
	"Id":4
	"NomeCliente":"Fulando",
	"SobreNome": "De Tal",
	"CPF":"22222222222",
	"RG":"223334445",
	"TelFixo":"1122334455",
	"Celular":"11923324554",
	"Email":"cliente@teste.com",
	"DtNascimento":"1982-04-05",
	"Ativo":true,
	"UpdateEnderecoDTO":{
		"Logradouro":"Rua amarela",
		"Bairro": "Bairro das Cores",
		"CEP":"19023453",
		"ClienteId":1,
		"FuncionarioId":null,
		"CidadeId":1,
        "Numero":10
	}
}

//FUNCIONÁRIO

{
	"NomeFuncionario":"Fulando",
	"SobreNome": "De Tal",
	"CPF":"22222222222",
	"RG":"223334445",
	"TelFixo":"1122334455",
	"Celular":"11923324554",
	"Email":"cliente@teste.com",
	"DtNascimento":"1982-04-05",
	"Ativo":true,
	"CreateEnderecoDTO":{
		"Logradouro":"Rua amarela",
		"Bairro": "Bairro das Cores",
		"CEP":"19023453",
		"FuncionarioId":null,
		"CidadeId":1,
        "Numero":10
	}
}


//FILME

{
	"id": 1,
	"titulo": "Os Infiltrados",
	"duracao": 120,
	"descricao": "blablablablablablablablabla",
	"dtInclusao": "2022-07-02T23:33:06.263799",
	"anoLancamento": 1999,
	"disponivel": true,
	"valorLocacao": 12,
	"generoId": 1,
	"produtoraId": 1,
	"ReadAtorDTOs":[
		{
        "id": 1,
        "nomeAtor": "jack",
        "sobreNome": "nicholson",
        "dtNascimento": "1982-04-05T00:00:00"
		}
	]
}