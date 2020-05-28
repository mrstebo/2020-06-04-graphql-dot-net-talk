import { useMutation, useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useParams } from 'react-router-dom';
import { Container, Divider, Segment } from 'semantic-ui-react';
import {
  BookInformation,
  BookReviewForm,
  IBookReviewFormData,
} from '../components';
import { SubscribedBookReviewList } from '../containers';
import { CREATE_BOOK_REVIEW } from '../graphql/mutations';
import { GET_BOOK } from '../graphql/queries';

export const BookDetailsPage: React.FC = () => {
  const { bookId } = useParams();
  const { loading, error, data, subscribeToMore } = useQuery(GET_BOOK, {
    variables: {
      bookId,
    },
  });
  const [createBookReview] = useMutation(CREATE_BOOK_REVIEW);

  const handleBookReviewFormSubmitted = (formData: IBookReviewFormData) => {
    createBookReview({
      variables: {
        input: {
          bookId,
          name: formData.name,
          title: formData.title,
          content: formData.review,
        },
      },
    });
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
        <Divider />
        <SubscribedBookReviewList bookId={bookId} data={data.book.reviews} />
      </div>
    );
  };

  return <Container>{renderContent()}</Container>;
};
