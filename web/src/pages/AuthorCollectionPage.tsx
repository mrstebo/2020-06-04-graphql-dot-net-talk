import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useHistory } from 'react-router-dom';
import { Container, Header, Segment } from 'semantic-ui-react';
import { AuthorList, IAuthorListItem } from '../components';
import { GET_AUTHORS } from '../graphql/queries';

export const AuthorCollectionPage: React.FC = () => {
  const history = useHistory();
  const { loading, error, data } = useQuery(GET_AUTHORS);

  const handleAuthorClicked = (author: IAuthorListItem) => {
    history.push(`/authors/${author.id}`);
  };

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

    return (
      <AuthorList data={data.authors} onAuthorClicked={handleAuthorClicked} />
    );
  };

  return (
    <Container>
      <Header size="huge">Author Collection</Header>
      {renderItems()}
    </Container>
  );
};
