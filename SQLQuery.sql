SELECT [p].[Name] AS [Имя продукта], [c].[Name] AS [Имя категории]
FROM 
	[dbo].[ProductsCategories] AS [pc] RIGHT JOIN
	[dbo].[Products] AS [p] ON [p].[Id] = [pc].[ProductId] LEFT JOIN
	[dbo].[Categories] AS [c] ON [c].[Id] = [pc].[CategoryId]