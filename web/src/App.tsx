import { ApolloProvider } from '@apollo/react-hooks';
import React from 'react';
import { BrowserRouter, Redirect, Route, Switch } from 'react-router-dom';
import apolloClient from './apollo-client';
import styles from './App.module.scss';
import { Header } from './components';
import {
  AuthorCollectionPage,
  BookCollectionPage,
  BookDetailsPage,
} from './pages';

const App: React.FC = () => {
  return (
    <BrowserRouter>
      <ApolloProvider client={apolloClient}>
        <div className={styles.container}>
          <Header className={styles.header} />
          <Switch>
            <Route
              exact={true}
              path="/authors"
              component={AuthorCollectionPage}
            />
            <Route exact={true} path="/books" component={BookCollectionPage} />
            <Route
              exact={true}
              path="/books/:bookId"
              component={BookDetailsPage}
            />
            <Redirect to="/books" />
          </Switch>
        </div>
      </ApolloProvider>
    </BrowserRouter>
  );
};

export default App;
