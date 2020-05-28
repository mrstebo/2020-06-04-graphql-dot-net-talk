import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useParams } from 'react-router-dom';
import {
  Container,
  Divider,
  Grid,
  Header,
  Image,
  Segment,
} from 'semantic-ui-react';
import { GET_BOOK } from '../graphql/queries';

export const BookDetailsPage: React.FC = () => {
  const { bookId } = useParams();
  const { loading, error, data } = useQuery(GET_BOOK, {
    variables: {
      bookId,
    },
  });

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
      <>
        <Header size="huge">
          {data.book.name}
          <Header.Subheader>{data.book.author.name}</Header.Subheader>
        </Header>
        <Divider />
        <Grid>
          <Grid.Row>
            <Grid.Column width="5">
              <Image src={data.book.imageUrl} />
            </Grid.Column>
            <Grid.Column width="9">
              <div
                dangerouslySetInnerHTML={{ __html: data.book.description }}
              />
            </Grid.Column>
          </Grid.Row>
        </Grid>
      </>
    );
  };

  return <Container>{renderContent()}</Container>;
};
