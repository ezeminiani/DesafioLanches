use DesafioLancheDB;


-- Script para recuperar os lanches ativos e seus ingredientes (não considera lanche em promoção).
SELECT * FROM LANCHE L
LEFT OUTER JOIN LANCHExINGREDIENTE X ON X.LxiLancheId = L.Id
LEFT OUTER JOIN INGREDIENTE I ON I.Id = X.LxiIngredienteId
WHERE L.LchStatus = 1 AND L.LchEpromocao = 0
ORDER BY L.LchNome, I.IngNome


-- Script para recuperar as promoções ativas.
SELECT * FROM PROMOCAO P
LEFT OUTER JOIN PROMOCAOxINGREDIENTE X ON X.PxiPromocaoId = P.Id
LEFT OUTER JOIN INGREDIENTE I ON I.Id = X.PxiIngredienteId
LEFT OUTER JOIN LANCHE L ON L.Id = P.ProLancheId
WHERE P.ProStatus = 1
ORDER BY P.ProNome


-- Script para recuperar o cliente com os seus endereços.
SELECT * FROM CLIENTE C 
LEFT OUTER JOIN ENDERECO E ON E.EndClienteId = C.Id
ORDER BY C.CliNome
