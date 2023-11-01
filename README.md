# NearMe

NearMe is our 2023 Congressional App Challenge submission. It was developed by [@theron-wang](https://github.com/theron-wang), [@aumshah](https://github.com/aumshah), [@tatvakabat](https://github.com/tatvakabat), and [@TheCoder215](https://github.com/TheCoder215).

## Features

![homepage](./media/homepage.png)
Homepage of NearMe


![catalog](./media/catalog.png)
Catalog showing local businesses, auto-sorted based on client user distance


![orders](./media/orders.png)
Users can order and rate products offered by each business on their page. Businesses can later update the status which users can see on their end.

## Running the App

1. Create a folder called `images` in `src\LocalBusinessDirectory`
2. Set up a local SQL Server 2022 instance and publish the database to it
3. Add the connection string to `secrets.json`
4. Run the app using `dotnet run`

