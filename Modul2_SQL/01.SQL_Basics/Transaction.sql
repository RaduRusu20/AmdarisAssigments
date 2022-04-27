USE DatabaseAssigment;

BEGIN TRY
	BEGIN TRANSACTION

	UPDATE dbo.Customers
	SET Email = 'rusu.radu@amdaris.com'
	WHERE FirstName LIKE 'Radu'

	UPDATE dbo.Products
	SET Price = 'radu'
	WHERE _Name LIKE 'jaloane'

	UPDATE dbo.ShoppingCartsProducts
	SET ShoppingCartId = 3
	WHERE ProductId = 1

	DELETE FROM dbo.Customers 
	WHERE LastName = 'Marinescu'

	DELETE FROM dbo.ShoppingCartsProducts
	WHERE ProductId = 100

	COMMIT TRANSACTION
END TRY

BEGIN CATCH
ROLLBACK TRANSACTION
END CATCH