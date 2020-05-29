import { InMemoryCache } from 'apollo-cache-inmemory';
import { ApolloClient } from 'apollo-client';
import { HttpLink } from 'apollo-link-http';
import { RetryLink } from 'apollo-link-retry';
import { WebSocketLink } from 'apollo-link-ws';
import { getMainDefinition } from 'apollo-utilities';

const API_URL = process.env.REACT_APP_API_URL;
const SUBSCRIPTION_URL = process.env.REACT_APP_SUBSCRIPTION_URL;

const httpLink = new HttpLink({
  uri: `${API_URL}`,
});

const wsLink = new WebSocketLink({
  uri: `${SUBSCRIPTION_URL}`,
  options: {
    reconnect: true,
    timeout: 30000,
  },
});

const retryLink = new RetryLink({ attempts: { max: Infinity } });

const link = retryLink.split(
  ({ query }) => {
    const definition = getMainDefinition(query);
    return (
      definition.kind === 'OperationDefinition' &&
      definition.operation === 'subscription'
    );
  },
  wsLink,
  httpLink
);

const client = new ApolloClient({
  cache: new InMemoryCache(),
  link,
});

export default client;
