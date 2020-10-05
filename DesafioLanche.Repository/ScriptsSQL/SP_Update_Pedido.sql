USE [DesafioLancheDB]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[SP_UPDATE_PEDIDO] 
@IdPedido BigInt,
@SubTotal Decimal,
@Desconto Decimal,
@Total Decimal,
@LinhaAfetada Int Output
AS

	BEGIN
		SET NOCOUNT ON;

		UPDATE PEDIDO SET PedSubTotal = @SubTotal, PedDescontoTotal = @Desconto, PedTotal = @Total
		WHERE Id = @IdPedido
		SELECT @LinhaAfetada = @@ROWCOUNT

		SELECT @LinhaAfetada as LinhaAfetada;

	END
GO


/*
Para executar, exemplo:

DECLARE @LinhaAfetada Int;
EXEC SP_UPDATE_PEDIDO 4, 10, 2, 8, @LinhaAfetada output
*/