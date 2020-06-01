import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useHistory, useParams } from 'react-router-dom';
import { Container, Divider, Header, Segment } from 'semantic-ui-react';
import { AuthorInformation, BookList, IBookListItem } from '../components';
import { GET_AUTHOR } from '../graphql/queries';

export const AuthorDetailsPage: React.FC = () => {
  const history = useHistory();
  const { authorId } = useParams();
  const { loading, error, data } = useQuery(GET_AUTHOR, {
    variables: {
      authorId,
    },
  });

  const handleBookClicked = (book: IBookListItem) => {
    history.push(`/books/${book.id}`);
  };

  const renderContent = () => {
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
      <div>
        <AuthorInformation {...data.author} />
        <Divider />
        <Header size="large">Books</Header>
        <BookList data={data.author.books} onBookClicked={handleBookClicked} />
      </div>
    );
  };

  return <Container>{renderContent()}</Container>;
};
