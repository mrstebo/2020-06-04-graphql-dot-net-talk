# 2020-06-04-graphql-dot-net-talk

The example project that will be used for the [Behind The Buzzword GraphQL talk](https://www.meetup.com/Behind-The-Buzz-Word/events/270628477/)

Get the slides [here](https://docs.google.com/presentation/d/e/2PACX-1vSbiOrzGnN6JSQZHfgsDq73BLrGrqWHFc2A0jbqTxvNTit5MRkdxvkkvQlu92EWvPjWpmSxu-aACaVd/pub?start=false&loop=false&delayms=3000)

This application demonstrates the following concepts of GraphQL:

- Queries
- Mutations
- Subscriptions

---

## How to run this app

This app uses Docker with a Docker Compose configuration. This will spin up the following resources:

- A PostgreSQL Database
- A .NET Core Web API
- A React Web App

As long as you have Docker installed you can spin up the app with

```bash
docker-compose up
```

### How to access the app when it is running

Here are the links that you will be able to access:

- [http://localhost:3000]() - This is the Web App
- [http://localhost:5000/playground]() - This is the GraphQL Playground
- [http://localhost:5000/voyager]() - This allows you to see a visual representation of your GraphQL Schema
- [http://localhost:8080] - The Adminer app, which allows you to see what is in the database _(creds in docker-compose.yml)_

---

## Troubleshooting

- A docker container is already using the port
  - Run `docker stop $(docker ps -aq)` in the terminal to stop all running containers
