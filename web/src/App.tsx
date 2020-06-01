import { ApolloProvider } from '@apollo/react-hooks';
import React from 'react';
import { BrowserRouter, Redirect, Route, Switch } from 'react-router-dom';
import apolloClient from './apollo-client';
import styles from './App.module.scss';
import { Footer, Header } from './components';
import {
  AuthorCollectionPage,
  AuthorDetailsPage,
  BookCollectionPage,
  BookDetailsPage,
  WelcomePage,
} from './pages';

const App: React.FC = () => {
  return (
    <BrowserRouter>
      <ApolloProvider client={apolloClient}>
        <div className={styles.container}>
          <div>
            <Header className={styles.header} />
            <Switch>
              <Route exact={true} path="/" component={WelcomePage} />
              <Route
                exact={true}
                path="/authors"
                component={AuthorCollectionPage}
              />
              <Route
                exact={true}
                path="/authors/:authorId"
                component={AuthorDetailsPage}
              />
              <Route
                exact={true}
                path="/books"
                component={BookCollectionPage}
              />
              <Route
                exact={true}
                path="/books/:bookId"
                component={BookDetailsPage}
              />
              <Redirect to="/" />
            </Switch>
          </div>
          <Footer className={styles.footer} />
        </div>
      </ApolloProvider>
    </BrowserRouter>
  );
};

export default App;
