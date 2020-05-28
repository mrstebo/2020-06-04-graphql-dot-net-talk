import { useSubscription } from '@apollo/react-hooks';
import React, { useState } from 'react';
import { Digital as ActivityIndicator } from 'react-activity';
import { BookReviewList, IBookReviewListProps } from '../components';
import { ON_BOOK_REVIEW_ADDED } from '../graphql/subscriptions';

export interface ISubscribedBookReviewListProps extends IBookReviewListProps {
  bookId: number;
}

function withSubscription<T extends ISubscribedBookReviewListProps>(
  Component: React.ComponentType<T>
) {
  return (props: T) => {
    const [reviews] = useState(props.data);
    const { loading } = useSubscription(ON_BOOK_REVIEW_ADDED, {
      variables: {
        bookId: props.bookId,
      },
      skip: true,
      // onSubscriptionData: e => console.log(e),
    });

    // console.log(loading, error, data);

    if (loading) {
      return <ActivityIndicator />;
    }

    return <Component {...props} data={reviews} />;
  };
}

export const SubscribedBookReviewList = withSubscription(BookReviewList);
