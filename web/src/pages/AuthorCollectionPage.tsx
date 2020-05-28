import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { Container, Header, Segment } from 'semantic-ui-react';
import { AuthorList } from '../components';
import { GET_AUTHORS } from '../graphql/queries';

export const AuthorCollectionPage: React.FC = () => {
  const { loading, error, data } = useQuery(GET_AUTHORS);

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

    return <AuthorList data={data.authors} />;
  };

  return (
    <Container>
      <Header size="huge">Author Collection</Header>
      {renderItems()}
    </Container>
  );
};
