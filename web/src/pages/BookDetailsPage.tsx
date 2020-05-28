import { useMutation, useQuery } from '@apollo/react-hooks';
import React from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { useParams } from 'react-router-dom';
import { Container, Divider, Segment } from 'semantic-ui-react';
import {
  BookInformation,
  BookReviewForm,
  BookReviewList,
  IBookReviewFormData,
} from '../components';
import { SubscribedBookReviewList } from '../containers';
import { CREATE_BOOK_REVIEW } from '../graphql/mutations';
import { GET_BOOK } from '../graphql/queries';
import { ON_BOOK_REVIEW_ADDED } from '../graphql/subscriptions';

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

  const handleSubscribeToNewBookReviews = () => {
    subscribeToMore({
      document: ON_BOOK_REVIEW_ADDED,
      variables: {
        bookId,
      },
      updateQuery: (prev, { subscriptionData }) => {
        const newBookReview = subscriptionData.data.onBookReviewAdded;

        console.log(prev);

        return prev;
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
        <BookReviewList
          data={data.book.reviews}
          subscribeToNewBookReviews={handleSubscribeToNewBookReviews}
        />
      </div>
    );
  };

  return <Container>{renderContent()}</Container>;
};
