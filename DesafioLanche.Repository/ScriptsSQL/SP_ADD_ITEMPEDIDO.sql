USE [DesafioLancheDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_ADD_ITEMPEDIDO] 
@IdPedido BigInt,
@IdLanche BigInt,
@IdIngrediente BigInt,
@Quantidade Decimal,
@Valor Decimal(18,2)
AS

	BEGIN
		SET NOCOUNT ON;

		INSERT INTO PEDIDOxLANCHExINGREDIENTE (PliPedidoId, PliLancheId, PliIngredienteId, PliQuantidade, PliValor)
		VALUES (@IdPedido, @IdLanche, @IdIngrediente, @Quantidade, @Valor)

		-- Retorna os ingredientes com suas quantidades e valores
		SELECT L.LchNome AS NomeLanche, I.IngNome As Ingrediente,
		Sum(x.PliQuantidade) AS Quantidade, Sum(x.PliValor) as Valor
		FROM PEDIDO P
		INNER JOIN PEDIDOxLANCHExINGREDIENTE X ON X.PliPedidoId = P.Id
		INNER JOIN INGREDIENTE I ON I.Id = X.PliIngredienteId
		INNER JOIN LANCHE L ON L.Id = X.PliLancheId
		WHERE P.Id = @IdPedido
		Group By L.LchNome, I.IngNome

	END
GO


/*
Para executar, exemplo:

EXEC SP_ADD_ITEMPEDIDO 1, 1, 1, 1, 0.80
*/

