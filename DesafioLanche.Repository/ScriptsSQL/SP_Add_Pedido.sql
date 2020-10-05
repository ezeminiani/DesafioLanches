USE [DesafioLancheDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SP_ADD_PEDIDO] 
@IdCliente BigInt,
@IdPedido BigInt OUTPUT
AS

	BEGIN
		SET NOCOUNT ON;
	
		DECLARE @DataEmissao DateTime

		SET @DataEmissao = GETDATE()

		INSERT INTO PEDIDO (PedClienteId, PedDtEmissao, PedSubTotal, PedDescontoTotal, PedTotal) 
		VALUES (@IdCliente, @DataEmissao, 0, 0, 0)

		SET @IdPedido = SCOPE_IDENTITY()

		SELECT @IdPedido AS IdPedido

	END
GO


/*
Para executar, exemplo:

DECLARE @IdPedido BigInt;
EXEC SP_ADD_PEDIDO 1, @IdPedido output
*/


