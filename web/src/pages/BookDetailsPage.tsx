import { useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useParams } from 'react-router-dom';
import { Container, Divider, Segment } from 'semantic-ui-react';
import {
  BookInformation,
  BookReviewForm,
  IBookReviewFormData,
} from '../components';
import { GET_BOOK } from '../graphql/queries';

export const BookDetailsPage: React.FC = () => {
  const { bookId } = useParams();
  const { loading, error, data } = useQuery(GET_BOOK, {
    variables: {
      bookId,
    },
  });

  const handleBookReviewFormSubmitted = (formData: IBookReviewFormData) => {
    // Submit the form
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
        <BookInformation {...data.book} />
        <Divider />
        <BookReviewForm onSubmit={handleBookReviewFormSubmitted} />
      </div>
    );
  };

  return <Container>{renderContent()}</Container>;
};
