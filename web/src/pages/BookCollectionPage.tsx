import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { Container, Header, Segment } from 'semantic-ui-react';
import { BookList } from '../components';
import { GET_BOOKS } from '../graphql/queries';

export const BookCollectionPage: React.FC = () => {
  const { loading, error, data } = useQuery(GET_BOOKS);

  const renderItems = () => {
    if (loading) {
      return <ActivityIndicator />;
    }

    if (error) {
      return (
        <Segment inverted={true} color="red" tertiary={true}>
          {error.message}
        </Segment>
      );
    }

    return <BookList data={data.books} />;
  };

  return (
    <Container>
      <Header size="huge">Book Collection</Header>
      {renderItems()}
    </Container>
  );
};
