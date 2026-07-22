namespace StockApi.GraphQL.Inputs;

public record CreateStockInput(
    string Symbol,
    string Company,
    decimal Price
);